using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestHospital.Data;
using TestHospital.Models;

namespace TestHospital.Controllers
{
    public class HomeController : Controller
    {
        DataContext db = new DataContext();
        static ViewModel vmodel = new ViewModel();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddPatientDetails()
        {
            ViewBag.clist = new SelectList(db.City.ToList(), "Id", "CityName");

            return View();
        }
        [HttpPost]
        public ActionResult AddPatientDetails(ViewModel model,string TestName)
        {
            ViewBag.clist = new SelectList(db.City.ToList(), "Id", "CityName");

            vmodel = model;
            if (vmodel.PatientVM != null && vmodel.TestListVM != null)
            {
                AddRecords(vmodel.TestListVM);
            }

            return View();
        }
        public ActionResult AddTest(List<TestModel> tmodel)
        {
            vmodel.TestListVM = tmodel;
            if(vmodel.PatientVM!=null && vmodel.TestListVM!=null)
            {
                AddRecords(vmodel.TestListVM);
            }
            return RedirectToAction("AddPatientDetails");
            

        }

        public ActionResult GetHospitalListByCid(int cid)
        {
            var data = db.Hospital.Where(x => x.City_id == cid).ToList();
            ViewBag.sclist = new SelectList(data, "HospitalName", "HospitalName");
            return PartialView("_HospitalPartialView");
        }

        public void AddRecords(List<TestModel> tmodel)
        {
            PatientModel model = new PatientModel();
            if (vmodel.PatientVM != null)
            {
                model = vmodel.PatientVM;

                Patient pmodel = new Patient()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Age = model.Age,
                    City = model.City,
                    DOB = model.DOB,
                    AdmissionDate = model.AdmissionDate,
                    Hospital = model.Hospital,
                    DischargeDate = model.DischargeDate

                };

                pmodel.Test = new List<Test>();
                decimal total = 0;
                //to do something
                if (tmodel != null)
                {
                    foreach (TestModel m in tmodel)
                    {
                        pmodel.Test.Add(new Test()
                        {
                            PatientId = pmodel.Id,
                            TestName = m.TestName,
                            TestDate = m.TestDate,
                            TestPrice = m.TestPrice,
                            TestResult = m.TestResult,
                            DoctorRemarks = m.DoctorRemarks
                        });
                        total = total + (decimal)m.TestPrice;
                    }

                }
                pmodel.TotalAmount = total;
                //DataContext db = new DataContext();
                db.Patient.Add(pmodel);
                db.SaveChanges();
                vmodel.PatientVM = null;
            }

        }



    }
}