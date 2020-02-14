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
        
        [Display(Name = "Manufacturer")]
        [Required(ErrorMessage = "Manufacturer is Required")]
        [StringLength(50)]
        public string airplaneManufacturer { get; set; }

        [Display(Name = "Airplane Type")]
        [Required(ErrorMessage = "Airplane Type is Required")]
        [StringLength(50)]
        public string airplaneType { get; set; }

        [Display(Name = "Date Completed")]
        [Required(ErrorMessage = "Date is Required")]
        [DataType(DataType.Date)]
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