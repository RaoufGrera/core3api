using core3api.Model;
using System.Threading.Tasks;
using SystemData.Models;

namespace core3api.Interfaces
{
    public interface ITokenService
    {
        Task<VUser> CreateToken(AppUser user);
    }
}