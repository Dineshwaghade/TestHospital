using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TestHospital.Data
{
    public class Hospital
    {
        [Key]
        public int Id { get; set; }
        public string HospitalName { get; set; }
        [ForeignKey("City")]
        public Nullable<int> City_id { get; set; }
        public virtual City City { get; set; }

    }
}