using core3api.Model;
using HeyRed.Mime;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using SystemData;
using SystemData.Models;

namespace core3api.Services
{

    public interface IUserServices
    {
        VProfile Profile(string UserName);
        VProfile UploadImage(string UserName, IFormCollection formCollection);
        VProfile Edit(string UserName, VEdit data);
        Task<VProfile> GetById(int UserId);
    }
    public class UserService : IUserServices
    {
        private SystemContext _context;

        private readonly AppSettings _appSettings;
        private readonly UserManager<AppUser> _mUserManager;
        public UserService(SystemContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _mUserManager = userManager;
        }
        public VProfile Profile(string UserName)
        {
            var std = _context.AppUser.FirstOrDefault(a => a.UserName == UserName);

            if (std == null)
                return null;

            return FillProfile(std);
            

        }

        public VProfile Edit(string UserName,VEdit data)
        {

          
            var std = _context.AppUser.FirstOrDefault(a => a.UserName == UserName);
            switch (data.Name)
            {
                //social_status
                case "gender":
                    std.GenderId = _context.Gender.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                 //   var folderName = Path.Combine("StaticFiles", "Images");
                    var maleImagePath = "default-male.svg";
                    var femaleImagePath ="default-female.svg";

                    if (maleImagePath == std.Image)
                        std.Image = femaleImagePath;
                    

                    _context.SaveChanges();
                    break;
                case "seeking":
                    std.SeekingId = _context.Seeking.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "home":
                    std.HomeId = _context.Home.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "country":
                    std.CountryId = _context.Country.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "age":
                    std.AgeId = _context.Age.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "height":
                    std.HeightId = _context.Height.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "sector":

                    std.SectorId = _context.Sector.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "education":
                    std.EducationId = _context.Education.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "relationship":
                    std.RelationshipId = _context.Relationship.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "have_kids":
                    std.HavekidsId = _context.Havekids.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "zodiac":
                    std.ZodiacId = _context.Zodiac.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;

                //lifestyle
                case "family_values":
                    std.FamilyValuesId = _context.FamilyValues.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "relocate":
                    std.RelocateId = _context.Relocate.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "polygamy_opinion":
                    std.PolygamyOpinionId = _context.PolygamyOpinion.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "driver":
                    std.DriverId = _context.Driver.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "work":
                    std.WorkId = _context.Work.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "smoking":
                    std.SmokingId = _context.Smoking.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "want_kids":
                    std.WantKidsId = _context.WantKids.Where(o => o.Id == data.Value).Select(p => (p.Id != null) ? p.Id : null).SingleOrDefault();
                    _context.SaveChanges();
                    break;
                case "name":
                    std.Name = data.Value;
                    _context.SaveChanges();
                    break;
                case "about":
                    std.AboutMe = data.Value;
                    _context.SaveChanges();
                    break;
                case "looking":
                    std.SearchFor = data.Value;
                    _context.SaveChanges();
                    break;

            }
            std = _context.AppUser.FirstOrDefault(a => a.UserName == UserName);
            return FillProfile(std);
        }

        public VProfile UploadImage(string UserName, IFormCollection formCollection)
        {
            var std = _context.AppUser.FirstOrDefault(a => a.UserName == UserName);

            var file = formCollection.Files.First();
            //  var file = Request.Form.Files[0];
            var folderName = Path.Combine("StaticFiles", "Images");
            var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
            if (file.Length > 0)
            {

                var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');

                var mimeType = MimeTypesMap.GetMimeType(fileName); // => image/jpeg

                var ext = MimeTypesMap.GetExtension(mimeType); // => jpeg
                Random rd = new Random();
                int rand_num = rd.Next(100, 2000);
                fileName = std.UserName + rand_num + "." + ext;


                var fullPath = Path.Combine(pathToSave, fileName);
                var dbPath = Path.Combine(folderName, fileName);


                if (System.IO.File.Exists(fullPath))
                {
                    // return BadRequest("It IS Here");
                    System.IO.File.Delete(fullPath);
                }
                var maleImagePath = "default-male.svg";
                var femaleImagePath = "default-female.svg";
                if (std.Image != maleImagePath || std.Image != femaleImagePath)
                {
                   
                    var dbOldPath = Path.Combine(folderName, std.Image);
                    System.IO.File.Delete(dbOldPath);

                }
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                std.Image = fileName;
                _context.SaveChanges();

                 return FillProfile(std);
            }
            
                return null;
            
         
        }

        public VProfile FillProfile(AppUser objUser)
        {
            VProfile vProfile = new VProfile();
            vProfile.about = objUser.AboutMe;
            vProfile.country = objUser.CountryId;
            vProfile.home = objUser.HomeId;

            vProfile.seeking = objUser.SeekingId;

            vProfile.age = objUser.AgeId;
            vProfile.gender = objUser.GenderId;
            vProfile.height = objUser.HeightId;
            vProfile.have_kids = objUser.HavekidsId;
            vProfile.looking = objUser.SearchFor;
            vProfile.education = objUser.EducationId;
            vProfile.relationship = objUser.RelationshipId;
            vProfile.name = objUser.Name;
            vProfile.family_values = objUser.FamilyValuesId;
            vProfile.relocate = objUser.RelocateId;
            vProfile.polygamy_opinion = objUser.PolygamyOpinionId;
            vProfile.smoking = objUser.SmokingId;
            vProfile.sector = objUser.SectorId;
            vProfile.driver = objUser.DriverId;
            vProfile.work = objUser.WorkId;
            vProfile.want_kids = objUser.WantKidsId;
            vProfile.zodiac = objUser.ZodiacId;
            vProfile.image = objUser.Image;
            vProfile.id = objUser.Id;

            return vProfile;
        }

        public async Task<VProfile> GetById(int UserId)
        {
            var std = await _context.AppUser.SingleOrDefaultAsync(x => x.Id == UserId);
            if(std == null) return null;

            return FillProfile(std);

        }
    }
}
