using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SystemData;
using SystemData.Models;

namespace core3api.Seed
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetRequiredService<SystemContext>();
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            for (int i=120;i < 220;i++)
            {
                context.Height.AddRange(new Height { Id = i.ToString(), Name = "سم" + " " + i.ToString(), NameEn = "cm" + " " + i.ToString() });
            }
            context.SaveChangesAsync().Wait();

            for (int i = 18; i < 90; i++)
            {
                context.Age.AddRange(new Age { Id = i.ToString(), Name = "سنة" + " " + i.ToString(), NameEn = "years" + " " + i.ToString() });
            }
            context.SaveChangesAsync().Wait();


        
              
            context.Seeking.AddRange(new Seeking { Id = "marriage_normal", Name = "زواج عادي", NameEn = "Marriage" });
            context.Seeking.AddRange(new Seeking { Id = "marriage_misyar", Name = "زواج مسيار", NameEn = "Marriage Misyar" });
            context.Seeking.AddRange(new Seeking { Id = "marriage_poly", Name = "زواج تعدد", NameEn = "Marriage polygamy" });
            context.SaveChangesAsync().Wait();

            //Country 
            context.Country.AddRange(new Country { Id = "egybet", Name = "مصر", NameEn = "Egypet" });
            context.Country.AddRange(new Country { Id = "libya", Name = "ليبيا", NameEn = "Libya" });
            context.Country.AddRange(new Country { Id = "saudi", Name = "السعودية", NameEn = "Saudi Arabia" });
            context.Country.AddRange(new Country { Id = "iraq", Name = "العراق", NameEn = "Iraq" });
            context.Country.AddRange(new Country { Id = "algeria", Name = "الجزائر", NameEn = "Algeria" });
            context.Country.AddRange(new Country { Id = "jordan", Name = "الأردن", NameEn = "Jordan" });
            context.Country.AddRange(new Country { Id = "morocco", Name = "المغرب", NameEn = "Morocco" });
            context.Country.AddRange(new Country { Id = "tunisia", Name = "تونس", NameEn = "Tunisia" });
            context.Country.AddRange(new Country { Id = "sudan", Name = "السودان", NameEn = "Sudan" });
            context.Country.AddRange(new Country { Id = "emirates", Name = "الإمارات", NameEn = "Emirates" });
            context.Country.AddRange(new Country { Id = "oman", Name = "عمان", NameEn = "Oman" });
            context.Country.AddRange(new Country { Id = "qatar", Name = "قطر", NameEn = "Qatar" });
            context.Country.AddRange(new Country { Id = "yemen", Name = "اليمن", NameEn = "Yemen" });
            context.Country.AddRange(new Country { Id = "kuwait", Name = "الكويت", NameEn = "Kuwait" });
            context.Country.AddRange(new Country { Id = "bahrain", Name = "البحرين", NameEn = "Bahrain" });
            context.Country.AddRange(new Country { Id = "lebanon", Name = "لبنان", NameEn = "Lebanon" });
            context.Country.AddRange(new Country { Id = "palestinian", Name = "فلسطين", NameEn = "Palestinian" });
            context.Country.AddRange(new Country { Id = "syria", Name = "سوريا", NameEn = "Syria" });
            context.SaveChangesAsync().Wait();


            context.Home.AddRange(new Home { Id = "egybet", Name = "مصر", NameEn = "Egypet" });
            context.Home.AddRange(new Home { Id = "libya", Name = "ليبيا", NameEn = "Libya" });
            context.Home.AddRange(new Home { Id = "saudi", Name = "السعودية", NameEn = "Saudi Arabia" });
            context.Home.AddRange(new Home { Id = "iraq", Name = "العراق", NameEn = "Iraq" });
            context.Home.AddRange(new Home { Id = "algeria", Name = "الجزائر", NameEn = "Algeria" });
            context.Home.AddRange(new Home { Id = "jordan", Name = "الأردن", NameEn = "Jordan" });
            context.Home.AddRange(new Home { Id = "morocco", Name = "المغرب", NameEn = "Morocco" });
            context.Home.AddRange(new Home { Id = "tunisia", Name = "تونس", NameEn = "Tunisia" });
            context.Home.AddRange(new Home { Id = "sudan", Name = "السودان", NameEn = "Sudan" });
            context.Home.AddRange(new Home { Id = "emirates", Name = "الإمارات", NameEn = "Emirates" });
            context.Home.AddRange(new Home { Id = "oman", Name = "عمان", NameEn = "Oman" });
            context.Home.AddRange(new Home { Id = "qatar", Name = "قطر", NameEn = "Qatar" });
            context.Home.AddRange(new Home { Id = "yemen", Name = "اليمن", NameEn = "Yemen" });
            context.Home.AddRange(new Home { Id = "kuwait", Name = "الكويت", NameEn = "Kuwait" });
            context.Home.AddRange(new Home { Id = "bahrain", Name = "البحرين", NameEn = "Bahrain" });
            context.Home.AddRange(new Home { Id = "lebanon", Name = "لبنان", NameEn = "Lebanon" });
            context.Home.AddRange(new Home { Id = "palestinian", Name = "فلسطين", NameEn = "Palestinian" });
            context.Home.AddRange(new Home { Id = "syria", Name = "سوريا", NameEn = "Syria" });
            context.SaveChangesAsync().Wait();







            context.Gender.AddRange(new Gender { Id = "male", Name = "رجل", NameEn = "Man" });
            context.Gender.AddRange(new Gender { Id = "female", Name = "امراءة", NameEn = "Woman" });
            context.SaveChangesAsync().Wait();

            //  "label": "المهنة", Done
            context.Sector.AddRange(new Sector { Id= "administrative", Name = "تنظيم الخطط", NameEn = "Making big plans" });
            context.Sector.AddRange(new Sector { Id = "management", Name = "تشجيع الأخرين", NameEn = "Pushing people around" });
            context.Sector.AddRange(new Sector { Id = "finance", Name = "تكبير الأرقام", NameEn = "Number cruncher" });
            context.Sector.AddRange(new Sector { Id = "media", Name = "نشر الأخبار", NameEn = "Disrupting what we know" });
            context.Sector.AddRange(new Sector { Id = "artistic", Name = "تصميم المستقبل", NameEn = "Designing for the future" });
            context.Sector.AddRange(new Sector { Id = "entertainment", Name = "ترفيه الحضور", NameEn = "Entertaining guests" });
            context.Sector.AddRange(new Sector { Id = "beauty", Name = "العناية بالجمال", NameEn = "Beautifying life" });
            context.Sector.AddRange(new Sector { Id = "sales", Name = "زيادة المبيعات", NameEn = "Increasing sales" });
            context.Sector.AddRange(new Sector { Id = "social_services", Name = "التقرب من الناس", NameEn = "Working with people" });
            context.Sector.AddRange(new Sector { Id = "no_profit", Name = "خلق تأثير", NameEn = "Making an impact" });
            context.Sector.AddRange(new Sector { Id = "veterinary", Name = "وقاية الكوكب", NameEn = "Caring for the planet" });
            context.Sector.AddRange(new Sector { Id = "engineering", Name = "ابتكار معدات رائعة", NameEn = "Inventing cool gear" });
            context.Sector.AddRange(new Sector { Id = "it", Name = "تطوير التكنولوجيا", NameEn = "Keeping the tech going" });
            context.Sector.AddRange(new Sector { Id = "farming", Name = "زراعة الأرض", NameEn = "Using nature as office" });
            context.Sector.AddRange(new Sector { Id = "law_enforcement", Name = "المحافظة على الأمن", NameEn = "Keeping the peace" });
            context.Sector.AddRange(new Sector { Id = "military", Name = "معالجة المشاكل", NameEn = "Problem solver" });
            context.Sector.AddRange(new Sector { Id = "politics", Name = "تغيير العالم", NameEn = "Changing the world" });
            context.Sector.AddRange(new Sector { Id = "education", Name = "التعمق بالكتب", NameEn = "Drowning in books" });
            context.Sector.AddRange(new Sector { Id = "academic", Name = "اتقان المهارات", NameEn = "Perfecting skills" });
            context.Sector.AddRange(new Sector { Id = "care", Name = "رعاية الآخرين", NameEn = "Taking care of others" });
            context.Sector.AddRange(new Sector { Id = "health", Name = "معالجة الناس", NameEn = "Keeping the world healthy" });
            context.Sector.AddRange(new Sector { Id = "travel", Name = "التجول في العالم", NameEn = "Traveling the world" });
            context.Sector.AddRange(new Sector { Id = "production", Name = "تشغيل آلات", NameEn = "Handling machines" });
            context.Sector.AddRange(new Sector { Id = "magic", Name = "الفن", NameEn = "Wizard" });
            context.Sector.AddRange(new Sector { Id = "ninja", Name = "نينجا", NameEn = "Ninja" });
            context.Sector.AddRange(new Sector { Id = "rockstar", Name = "نجم روك", NameEn = "Rockstar" });
            context.Sector.AddRange(new Sector { Id = "talent", Name = "تعدد المواهب", NameEn = "Jack of all trades" });
            context.SaveChangesAsync().Wait();


            //Done Education
            context.Education.AddRange(new Education { Id = "elementary_school", Name = "إبتدائي", NameEn = "Elementary school" });
            context.Education.AddRange(new Education { Id = "vocational", Name = "تدريب مهني", NameEn = "Professionally trained" });
            context.Education.AddRange(new Education { Id = "high_school", Name = "ثانوي", NameEn = "High school" });
            context.Education.AddRange(new Education { Id = "technical_education", Name = "معهد تقني", NameEn = "Technical education" });
            context.Education.AddRange(new Education { Id = "academy", Name = "درجة الدبلوم", NameEn = "AP degree" });
            context.Education.AddRange(new Education { Id = "bachelors_degree", Name = "درجة البكالوريوس", NameEn = "Bachelor's degree" });
            context.Education.AddRange(new Education { Id = "masters_degree", Name = "درجة الماجستير", NameEn = "Master’s degree" });
            context.Education.AddRange(new Education { Id = "doctorate", Name = "درجة الدكتوراه", NameEn = "PhD" });
            context.Education.AddRange(new Education { Id = "school_of_life", Name = "مدرسة الحياة", NameEn = "School of Life" });


            //Done RelationShip
            context.Relationship.AddRange(new Relationship { Id = "single", NameEn = "Never been married", Name = "غير متزوج من قبل" });
            context.Relationship.AddRange(new Relationship { Id = "divorced", NameEn = "Divorced", Name = "مطلق" });
            context.Relationship.AddRange(new Relationship { Id = "widowed", NameEn = "Widowed", Name = "أرمل" });
            context.Relationship.AddRange(new Relationship { Id = "separated", NameEn = "Separated", Name = "منفصل" });
            context.Relationship.AddRange(new Relationship { Id = "annulled", NameEn = "Annulled", Name = "فاسخ عقد الزواج" });
            context.Relationship.AddRange(new Relationship { Id = "married", NameEn = "Married", Name = "متزوج" });
            context.SaveChangesAsync().Wait();


            // Have Kids Done
            context.Havekids.AddRange(new Havekids { Id = "no", Name = "لا يوجد أطفال", NameEn = "Don’t have kids" });
            context.Havekids.AddRange(new Havekids { Id = "yes", Name = "يوجد أطفال", NameEn = "Have kids" });
            context.SaveChangesAsync().Wait();


            // Zodic Done
            context.Zodiac.AddRange(new Zodiac { Id = "aries", Name = "الحمل", NameEn = "Aries" });
            context.Zodiac.AddRange(new Zodiac { Id = "taurus", Name = "الثور", NameEn = "Taurus" });
            context.Zodiac.AddRange(new Zodiac { Id = "gemini", Name = "الجوزاء", NameEn = "Gemini" });
            context.Zodiac.AddRange(new Zodiac { Id = "cancer", Name = "السرطان", NameEn = "Cancer" });
            context.Zodiac.AddRange(new Zodiac { Id = "leo", Name = "الأسد", NameEn = "Leo" });
            context.Zodiac.AddRange(new Zodiac { Id = "virgo", Name = "العذراء", NameEn = "Virgo" });
            context.Zodiac.AddRange(new Zodiac { Id = "libra", Name = "الميزان", NameEn = "Libra" });
            context.Zodiac.AddRange(new Zodiac { Id = "scorpio", Name = "العقرب", NameEn = "Scorpio" });
            context.Zodiac.AddRange(new Zodiac { Id = "sagittarius", Name = "القوس", NameEn = "Sagittarius" });
            context.Zodiac.AddRange(new Zodiac { Id = "capricorn", Name = "الجدي", NameEn = "Capricorn" });
            context.Zodiac.AddRange(new Zodiac { Id = "aquarius", Name = "الدلو", NameEn = "Aquarius" });
            context.Zodiac.AddRange(new Zodiac { Id = "pisces", Name = "الحوت", NameEn = "Pisces" });
            context.SaveChangesAsync().Wait();

         
            // التدين done 
            context.FamilyValues.AddRange(new FamilyValues { Id = "practising", Name = "ملتزم جدا", NameEn = "Very practising" });
            context.FamilyValues.AddRange(new FamilyValues { Id = "moderate", Name = "ملتزم بشكل معتدل", NameEn = "Moderately practising" });
            context.FamilyValues.AddRange(new FamilyValues { Id = "secular", Name = "غير ملتزم", NameEn = "Not practising" });
            context.SaveChangesAsync().Wait();

  
            //done الاستعداد للأنتقال
            context.Relocate.AddRange(new Relocate { Id = "willing", Name = "مستعد للانتقال", NameEn = "Open to relocate" });
            context.Relocate.AddRange(new Relocate { Id = "not_sure", Name = "تغيير المكان قابل للنقاش", NameEn = "Unsure about relocating" });
            context.Relocate.AddRange(new Relocate { Id = "stay", Name = "غير مستعد للانتقال", NameEn = "Not willing to relocate" });
            context.SaveChangesAsync().Wait();

            //Done 
            context.PolygamyOpinion.AddRange(new PolygamyOpinion { Id = "accept", Name = "مع تعدد الزوجات", NameEn = "Accept polygamy" });
            context.PolygamyOpinion.AddRange(new PolygamyOpinion { Id = "maybe", Name = "التعدد إن دعت الضرورة", NameEn = "Might accept polygamy" });
            context.PolygamyOpinion.AddRange(new PolygamyOpinion { Id = "not_accept", Name = "ضد تعدد الزوجات", NameEn = "Don’t accept polygamy" });
            context.SaveChangesAsync().Wait();
       


            //Done
            context.Driver.AddRange(new Driver { Id = "accept", Name = "مع قيادة المرأة", NameEn = "Accept women driving" });
            context.Driver.AddRange(new Driver { Id = "maybe", Name = "القيادة إن دعت الضرورة", NameEn = "Might accept women driving" });
            context.Driver.AddRange(new Driver { Id = "not_accept", Name = "ضد قيادة المرأة", NameEn = "Don’t accept women driving" });
            context.SaveChangesAsync().Wait();
       

            //Done
            context.Work.AddRange(new Work { Id = "accept", Name = "مع عمل المرأة", NameEn = "Accept women's work" });
            context.Work.AddRange(new Work { Id = "maybe", Name = "العمل إن دعت الضرورة", NameEn = "Might accept women's work" });
            context.Work.AddRange(new Work { Id = "not_accept", Name = "ضد عمل المرأة", NameEn = "Don’t accept women's work" });
            context.SaveChangesAsync().Wait();



            //Done
            context.Smoking.AddRange(new Smoking { Id = "no", Name = "غير مدخن", NameEn = "Non-smoker" });
            context.Smoking.AddRange(new Smoking { Id = "quiting", Name = "جاري إيقاف التدخين", NameEn = "Trying to quit smoking" });
            context.Smoking.AddRange(new Smoking { Id = "occasionaly", Name = "مدخن في المناسبات", NameEn = "Social smoker" });
            context.Smoking.AddRange(new Smoking { Id = "daily", Name = "مدخن", NameEn = "Smoker" });
            context.Smoking.AddRange(new Smoking { Id = "waterpipe", Name = "السهر مع الشيشة", NameEn = "Enjoy smoking shisha" });
            context.Smoking.AddRange(new Smoking { Id = "vaping", Name = "سيجارة إلكترونية", NameEn = "Puffing on e-cigarettes" });
            context.SaveChangesAsync().Wait();



            //Done
            context.WantKids.AddRange(new WantKids { Id = "asap", Name = "مستعد للحصول على أطفال", NameEn = "Want kids soon" });
            context.WantKids.AddRange(new WantKids { Id = "someday", Name = "مع إنجاب الأطفال يوما ما", NameEn = "Wants kids someday" });
            context.WantKids.AddRange(new WantKids { Id = "more", Name = "مع فكرة تكثير الأولاد", NameEn = "Open to get more kids" });
            context.WantKids.AddRange(new WantKids { Id = "not_sure", Name = "موضوع الإنجاب غير أكيد", NameEn = "Not sure about getting kids" });
            context.WantKids.AddRange(new WantKids { Id = "enough", Name = "لا للمزيد من الأولاد", NameEn = "Have enough kids" });
            context.WantKids.AddRange(new WantKids { Id = "no", Name = "لا رغبة بإنجاب الأطفال", NameEn = "Don’t want kids" });
            context.SaveChangesAsync().Wait();
  


        }
       

        public static async Task SeedUsers(UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager)
        {
            if (await userManager.Users.AnyAsync()) return;

           //  var userData = await System.IO.File.ReadAllTextAsync("Data/UserSeedData.json");
            // var users = JsonSerializer.Deserialize<List<AppUser>>(userData);
           //  if (users == null) return;

            var roles = new List<AppRole>
            {
                new AppRole{Name = "Member"},
                new AppRole{Name = "Admin"},
                new AppRole{Name = "Moderator"},
            };

            foreach (var role in roles)
            {
                await roleManager.CreateAsync(role);
            }

            AppUser user = new AppUser
            {
                Name = "sara",
                UserName = "sara",
                Email = "sara@yahoo.cc"
                ,
                GenderId = "male"
                
            };

            await userManager.CreateAsync(user, "Pa$$w0rd");
            await userManager.AddToRoleAsync(user, "Member");

            //foreach (var user in users)
            //{
            //    user.UserName = user.UserName.ToLower();
            //    await userManager.CreateAsync(user, "Pa$$w0rd");
            //    await userManager.AddToRoleAsync(user, "Member");
            //}

            var admin = new AppUser
            {
                UserName = "admin"
            };

            await userManager.CreateAsync(admin, "Pa$$w0rd");
            await userManager.AddToRolesAsync(admin, new[] { "Admin", "Moderator" });
        }

    }
}
