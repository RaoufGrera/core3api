using System.Collections.Generic;
using System.Threading.Tasks;

using core3api.Helpers;
using core3api.Model;
using SystemData.Models;

namespace core3api.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser> GetUserByIdAsync(int id);
        Task<AppUser> GetUserByUsernameAsync(string username);
        Task<PagedList<VProfile>> GetMembersAsync(UserParams userParams);
        Task<VProfile> GetMemberAsync(string username);
        Task<string> GetUserGender(string username);
    }
}