using core3api.Model;
using core3api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;
using SystemData;

namespace core3api.Controllers.v1
{
    [Route("v1/[controller]")]
    public class UserController : Controller
    {

        public IUserServices _userService;
        protected SystemContext _context;
        public UserController(SystemContext context,IUserServices userService )
        {
            _userService = userService;
            _context = context;
        }


        // [Authorize]
        [HttpGet]
        [Route("profile/{userId}")]
        public IActionResult GetById(int userId)
        {
            var user = _userService.GetById(userId);
            if(user.Result == null)
                return NotFound();
            return Ok(user.Result);

        }

        [Authorize]
        [HttpGet("profile")]
        public IActionResult profile()
        {
            var userName = User.Identity.Name;
            var user = _userService.Profile(userName);
            if (user == null)
                return StatusCode(500, "Internal server error:profile");

            return Ok(user);
        }

        [Authorize]
        [HttpPost("edit")]
        public IActionResult edit([FromBody] VEdit data)
        {
            var userName = User.Identity.Name;
            var user = _userService.Edit(userName, data);
            if (user == null)
               return BadRequest();
            return Ok(user);
           
        }


        [Authorize]
        [RequestSizeLimit(400_000)]
        [HttpPost("upload")]
        public async Task<IActionResult> UploadAsync()
        {
            try
            {
                var userName = User.Identity.Name;
                IFormCollection formCollection = await Request.ReadFormAsync();
                if (formCollection == null)
                    return BadRequest();

                var user = _userService.UploadImage(userName, formCollection);
                if(user == null)
                    return BadRequest();

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex}");
            }
        }
    }
}
