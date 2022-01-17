using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SystemData;

using Microsoft.EntityFrameworkCore;
using SystemData.Models;
using core3api.Model;
using core3api.Helpers;
using core3api.Interfaces;

namespace core3api.Data
{
    public class LikesRepository : ILikesRepository
    {
        private readonly SystemContext _context;
        public LikesRepository(SystemContext context)
        {
            _context = context;
        }

        public async Task<UserLike> GetUserLike(int sourceUserId, int likedUserId)
        {
            return await _context.Likes.FindAsync(sourceUserId, likedUserId);
        }

        public async Task<PagedList<VLike>> GetUserLikes(LikesParams likesParams)
        {
            var users = _context.Users.OrderBy(u => u.UserName).AsQueryable();
            var likes = _context.Likes.AsQueryable();

            if (likesParams.Predicate == "liked")
            {
                likes = likes.Where(like => like.SourceUserId == likesParams.UserId);
                users = likes.Select(like => like.LikedUser);
            }

            if (likesParams.Predicate == "likedBy")
            {
                likes = likes.Where(like => like.LikedUserId == likesParams.UserId);
                users = likes.Select(like => like.SourceUser);
            }

            var likedUsers = users.Select(user => new VLike
            {
                Username = user.UserName,
                Name = user.Name,
                Age = user.AgeId,
                Image = user.Image,
                City = user.CountryId,
                Id = user.Id
            });

            return await PagedList<VLike>.CreateAsync(likedUsers, 
                likesParams.PageNumber, likesParams.PageSize);
        }

        public async Task<AppUser> GetUserWithLikes(int userId)
        {
            return await _context.Users
                .Include(x => x.LikedUsers)
                .FirstOrDefaultAsync(x => x.Id == userId);
        }
    }
}