using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestHospital.Models
{
    public class HostpitalModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string HospitalName { get; set; }
        [ForeignKey("City")]
        public Nullable<int> City_id { get; set; }
        public virtual CityModel CityModel { get; set; }

    }
}