using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemData.Models
{
   
    public class Notification
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }

     
        public bool IsRead { get; set; }

        public DateTime ReadAt { get; set; }



    }
}
