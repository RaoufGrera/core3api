namespace SystemData.Models
{
    public class UserLike
    {
        public AppUser SourceUser { get; set; }
        public long SourceUserId { get; set; }

        public AppUser LikedUser { get; set; }
        public long LikedUserId { get; set; }
    }
}