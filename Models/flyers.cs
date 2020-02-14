using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tk848615_MIS4200.Models
{
    public class flyers
    {

        [Key]
        public int flyerID { get; set; }
       
        [Display(Name = "First Name")]
        [Required(ErrorMessage ="First Name is Required")]
        [StringLength(50)]
        public string flyerFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(50)]
        public string flyerLastName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }


        public string fullName
        {
            get
            {
                return flyerLastName + ", " + flyerFirstName;
            }

        }

        public ICollection<flights> Flights { get; set; }



    }
}