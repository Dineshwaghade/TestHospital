using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestHospital.Data
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }
        [Required,Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public string Hospital { get; set; }
        public DateTime? DischargeDate { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string City_Id { get; set; }
        public string Hospital_id { get; set; }
        public int Test_Id { get; set; }
        public ICollection<Test> Test { get; set; }

    }
}