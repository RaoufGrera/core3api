using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SystemData;
using Microsoft.OpenApi.Models;
using System;
using Microsoft.EntityFrameworkCore;
using core3api.Services;
using core3api.Extensions;
using core3api.SignalR;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.SpaServices.Extensions;
using Microsoft.Extensions.FileProviders;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace core3api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            SchedulerTask.StartAsync().GetAwaiter().GetResult();
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {



            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowAll",
            //          builder =>
            //          {
            //              builder //.WithOrigins("https://localhost:3000")
            //              .AllowAnyOrigin()
            //                     .AllowAnyHeader()
            //                        .AllowAnyMethod();
            //          });
            //});

            services.AddControllersWithViews(options =>
    options.ModelBinderProviders.RemoveType<DateTimeModelBinderProvider>());
            services.AddDbContext<SystemContext>(options =>
                options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddIdentity<AppUser, AppRole>()

            //  .AddEntityFrameworkStores<SystemContext>()
            //  .AddDefaultTokenProviders();



            // services.AddControllers();
            services.AddApplicationServices(config: Configuration);
            services.AddIdentityServices(Configuration);
            services.AddSignalR();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Zawag API",
                    Version = "v1",
                    Description = "Description for the API goes here.",
                    Contact = new OpenApiContact
                    {
                        Name = "Raouf Grera",
                        Email = string.Empty,
                        Url = new Uri("https://libyacv.com/"),
                    },
                });
            });

            services.AddSpaStaticFiles(config =>
            {
                config.RootPath = "dist";
            });


            //  services.AddCors();
            //  services.AddControllers();

            //  services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            SystemContext con = (SystemContext)serviceProvider.GetService(typeof(SystemContext));
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);


            //app.UseCors(x => x
            //.AllowAnyOrigin()
            //.AllowAnyMethod()
            //.AllowAnyHeader());
            /* if (con != null) {

              con.Database.EnsureDeleted();

             con.Database.EnsureCreated();
          }*/
            //app.UseStaticFiles();

            //  app.UseSpaStaticFiles();

            app.UseStaticFiles(new StaticFileOptions()
            {
                //FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot/StaticFiles")),
                //RequestPath = new PathString("/wwwroot/StaticFiles"),
                OnPrepareResponse = ctx =>
                {
                    ctx.Context.Response.Headers.Append("Access-Control-Allow-Origin", "*");
                    ctx.Context.Response.Headers.Append("Access-Control-Allow-Headers",
                      "*");
                },

            });


            //app.UseCors(x => x
            //   .AllowAnyMethod()
            //   .AllowAnyHeader()
            //   .WithOrigins("http://localhost:3000"));

            // .SetIsOriginAllowed(origin => true)); // allow credentials





            if (env.IsDevelopment())
            {
                app.UseCors(x => x.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
                .WithOrigins("http://localhost:3000", "https://localhost:3000"));//                    .WithOrigins("https://localhost:3000"));

                app.UseCors("AllowAll");
            }
            app.UseCors(x => x.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials()
                    .WithOrigins("https://localhost", "https://myletter.app"));
            app.UseCors("AllowAll");



            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Zomato API V1");
                c.RoutePrefix = "";
            });

            app.UseHttpsRedirection();


            app.UseRouting();
            //  app.UseCors(x => x
            //.AllowAnyMethod()
            //.AllowAnyHeader()
            // .WithOrigins("https://localhost:3000")
            //.SetIsOriginAllowed(origin => true) // allow any origin
            //                                    // .WithHeaders(HeaderNames.ContentType, HeaderNames.Accept)
            //                                    // .AllowAnyOrigin()
            //.AllowCredentials()
            //); // allow credentials



            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<PresenceHub>("hubs/presence");
                endpoints.MapHub<MessageHub>("hubs/message");

            });

            //app.UseSpa(spa =>
            //{

            //    if (env.IsDevelopment())
            //    {
            //        spa.UseProxyToSpaDevelopmentServer("http://localhost:3000");
            //    }
            //});




        }
    }
}
