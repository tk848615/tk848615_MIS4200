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
        
        public string flightName { get; set; }
        [Display(Name = "Destination")]
     
        public string destination { get; set; }
        [Display(Name = "Date of Flight")]
        public DateTime dateOfFlight { get; set; }

        
        
        [Display(Name = "Airplane")]
        public int airplaneID { get; set; }
        public virtual airplanes Airplanes { get; set; }
       
        
        
        [Display(Name = "Flyer")]
        public int flyerID { get; set; }
        public virtual flyers Flyers { get; set; }


    }
}