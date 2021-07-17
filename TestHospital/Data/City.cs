using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestHospital.Data
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string CityName { get; set; }

    }
}