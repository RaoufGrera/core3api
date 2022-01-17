using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SystemData.Models
{
    public class Favorite
    { //  مفضلة السيارات الخاصة باليوزر
        public int Id { get; set; }
        public AppUser AppUser { get; set; }
        public int? AppUserId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
    }
}
