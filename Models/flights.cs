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

        public string flightName { get; set; }
        public string destination { get; set; }

        public DateTime dateOfFlight { get; set; }


        public int airplaneID { get; set; }
        public virtual airplanes Airplanes { get; set; }
        public int flyerID { get; set; }
        public virtual flyers Flyers { get; set; }


    }
}