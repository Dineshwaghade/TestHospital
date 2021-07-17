using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestHospital.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        [Required,Display(Name ="Test Name")]
        public string TestName { get; set; }
        [Required, Display(Name = "Test date"), DataType(DataType.Date)]
        public DateTime? TestDate { get; set; }
        public Nullable<decimal> TestPrice { get; set; }
        [Required, Display(Name = "Test Result")]
        public string TestResult { get; set; }
        [Required, Display(Name = "Doctor Remarks")]
        public string DoctorRemarks { get; set; }
        public int PatientId { get; set; }
        public PatientModel PatientModel { get; set; }

    }
}