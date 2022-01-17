using System.Collections.Generic;
using System.Threading.Tasks;

using core3api.Helpers;
using core3api.Model;
using SystemData.Models;

namespace core3api.Interfaces
{
    public interface ILikesRepository
    {
        Task<UserLike> GetUserLike(int sourceUserId, int likedUserId);
        Task<AppUser> GetUserWithLikes(int userId);
        Task<PagedList<VLike>> GetUserLikes(LikesParams likesParams);
    }
}