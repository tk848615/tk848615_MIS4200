using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tk848615_MIS4200.Models
{
    public class flights
    {
      [Key]
        public int flightID { get; set; }

        [Display (Name = "Flight Name")]
        [Required(ErrorMessage = "Flight Name is Required")]
        [StringLength(50)]
        public string flightName { get; set; }

        [Display(Name = "Destination")]
        [Required(ErrorMessage = "Destination is Required")]
        [StringLength(50)]
        public string destination { get; set; }

        [Display(Name = "Date of Flight")]
        [Required(ErrorMessage = "Date is Required")]
        [DataType(DataType.Date)]
        public DateTime dateOfFlight { get; set; }

        
        
        [Display(Name = "Airplane")]
        public int airplaneID { get; set; }
        public virtual airplanes Airplanes { get; set; }
       
        
        
        [Display(Name = "Flyer")]
        public int flyerID { get; set; }
        public virtual flyers Flyers { get; set; }


    }
}