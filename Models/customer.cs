using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tk848615_MIS4200.Models
{
    public class customer
    {
        public int customerID { get; set; }
        public string customerFirstName { get; set; }
        public string customerLastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }

        public DateTime customerSince { get; set; }

    }
}