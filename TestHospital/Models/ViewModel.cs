using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestHospital.Models
{
    public class ViewModel
    {
        public int PatientId { get; set; }
        public int TestId { get; set; }
        public PatientModel PatientVM { get; set; }
        public TestModel TestVM { get; set; }
        public List<TestModel> TestListVM { get; set; }
        
    }
}