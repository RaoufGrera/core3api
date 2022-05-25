using Microsoft.AspNetCore.Mvc;
using SystemData;
namespace core3api.Controllers.v1
{

    [Route("v1/[controller]")]

    public class FireController : Controller
    {
       

            protected SystemContext _context;
            public FireController(SystemContext context)
            {
                _context = context;
            }


           

        
    }
}
