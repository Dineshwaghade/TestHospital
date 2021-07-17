using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestHospital.Models
{
    public class PatientModel
    {
        public int Id { get; set; }
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string City { get; set; }
        [Required, Display(Name = "DOB"), DataType(DataType.Date)]
        public DateTime? DOB { get; set; }
        [Required,Display(Name ="Admission date"),DataType(DataType.Date)]
        public DateTime? AdmissionDate { get; set; }
        //[Required]
        public string Hospital { get; set; }
        //[Required]
        [Required, Display(Name = "Discharge Date"), DataType(DataType.Date)]
        public DateTime? DischargeDate { get; set; }
        [Display(Name ="Total Amount")]
        public Nullable<decimal> TotalAmount { get; set; }
        public string City_Name { get; set; }
        public string Hospital_Name { get; set; }

    }
}