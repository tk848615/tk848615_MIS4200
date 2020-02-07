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
        
        public string flyerFirstName { get; set; }
        public string flyerLastName { get; set; }
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