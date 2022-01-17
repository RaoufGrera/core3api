using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace core3api.Model
{
    public class VUser
    {
        public long UserId;

        public string Name { get; set; }

        public string Gender { get; set; }

        public string UserName { get; set; }

        public string Image { get; set; }

        public string Message { get; set; }
        public string Token { get; set; }

    }

 
}
