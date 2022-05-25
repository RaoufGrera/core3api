using System;

namespace core3api.Model
{
    public class VNoti
    {
        public int Id { get; set; }
        public long UserId { get; set; }

        public string Name { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public bool IsRead { get; set; }
        public string TimeAgo { get; set; }
        public string TimeNumber { get; set; }

        public DateTime ReadAt { get; set; }
    }
}
