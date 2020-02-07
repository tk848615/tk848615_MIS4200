using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tk848615_MIS4200.Models
{
    public class airplanes
    {
        [Key]
        public int airplaneID { get; set; }

        public string airplaneManufacturer { get; set; }
        public string airplaneType { get; set; }
        public DateTime dateBuilt { get; set; }

        public string airplaneName
        {
            get
            {
                return airplaneManufacturer + ", " + airplaneType;
            }

        }

        public ICollection<flights> Flights { get; set; }


    }
}