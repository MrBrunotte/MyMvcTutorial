using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterLoginPart1.Models
{
    public class CarInfoModel
    {
        [Required, Display(Name = "Make of Car")]
        public string Make { get; set; }
        [Display(Name = "Color of your Car")]
        public string Color { get; set; }
        [Display(Name = "Type top Speed")]
        public int MaxSpeed { get; set; }

        // Navigation prop
       // public UserModel User { get; set; }
    }
}