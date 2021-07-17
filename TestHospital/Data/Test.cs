using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestHospital.Data
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string TestName { get; set; }
        public DateTime? TestDate { get; set; }
        public Nullable<decimal> TestPrice { get; set; }
        public string TestResult { get; set; }
        public string DoctorRemarks { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}