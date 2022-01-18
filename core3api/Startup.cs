using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SystemData;

using Microsoft.AspNetCore.Authentication.JwtBearer;

using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using core3api.Services;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using SystemData.Models;
using Microsoft.AspNetCore.Identity;
using System.IdentityModel.Tokens.Jwt;
using core3api.Model;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Http;
using core3api.Extensions;
using core3api.SignalR;

namespace core3api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {



           


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

        
              

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("AllowAll",
            //          builder =>
            //          {
            //              builder.WithOrigins("https://localhost:3001")
            //              .AllowAnyOrigin()
            //                     .AllowAnyHeader()
            //                        .AllowAnyMethod();
            //          });
            //});
         
          //  services.AddCors();
          //  services.AddControllers();

          //  services.AddMvc();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env ,IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            SystemContext con = (SystemContext)serviceProvider.GetService(typeof(SystemContext));

            /* if (con != null) {

              con.Database.EnsureDeleted();

             con.Database.EnsureCreated();
          }*/
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), @"StaticFiles")),
                RequestPath = new PathString("/StaticFiles")
            });

            //app.UseCors(x => x
            //   .AllowAnyMethod()
            //   .AllowAnyHeader()
            //   .WithOrigins("http://localhost:3000"));

            // .SetIsOriginAllowed(origin => true)); // allow credentials


            app.UseCors(x => x.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials()
            .WithOrigins("http://localhost:3000"));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Zomato API V1");
                c.RoutePrefix = string.Empty;
            });

             app.UseHttpsRedirection();


             app.UseRouting();
                
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapHub<PresenceHub>("hubs/presence");
              endpoints.MapHub<MessageHub>("hubs/message");

            });

          


        }
    }
}
