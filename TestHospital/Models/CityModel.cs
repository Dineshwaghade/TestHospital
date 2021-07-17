using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestHospital.Models
{
    public class CityModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string CityName { get; set; }

    }
}