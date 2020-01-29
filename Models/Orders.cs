using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace tk848615_MIS4200.Models
{
    public class Orders
    {
        [Key]

        public int OrderNum { get; set; }
        public string description { get; set; }
        public DateTime orderDate { get; set; }

        public int customerID { get; set; }

        public virtual customer Customer { get; set; }
    }
}