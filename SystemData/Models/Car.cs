using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SystemData.Models
{
    public class Car
    {
       

        public int Id { get; set; }
        [Required(ErrorMessage = "حقل {0} مطلوب")]
        [DisplayName("العنوان")]
        public string Title { get; set; }



 
        public int PaymentMethodId { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
 
        [Required(ErrorMessage = "حقل {0} مطلوب")]
        [DisplayName("اللون")]
        public int ColorId { get; set; }
 

        [Required]
         public string CarPrice { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsAvailble { get; set; }

        [DefaultValue("")]
        public string CarDescription { get; set; }

        //[DefaultValue(0)]
        //public decimal KmCrossed { get; set; }

        [DefaultValue(false)]
        public bool IsRegistered { get; set; }

        [DefaultValue(false)]
        public bool IsSold { get; set; }

        [DefaultValue(0)]
        public int Views { get; set; }

    

        [Required(ErrorMessage = "حقل {0} مطلوب")]
        [DisplayName("نوع السيارة")]
        public int CarModelId { get; set; }
 
        public int FlueId { get; set; }
         public string Rating { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
      //  public ICollection<City> City { get; set; }
    }
}