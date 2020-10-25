using RealEs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RealEs.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        private RealContext realContext = new RealContext();
        public ActionResult Index()
        {
            List<Staff> AllStaffs = realContext.Staffs.ToList();
            return View(AllStaffs);
        }
        public ActionResult Create()
        {
            //ViewBag.Branchdetails = new SelectList(realContext.Branches, "BranchNo", "BranchNo"); 
            ViewBag.Branchdetails = realContext.Branches;
            return View();
        }
        [HttpPost]
        public ActionResult Create(Staff staff)
        {
            ViewBag.Branchdetails = realContext.Branches;
            realContext.Staffs.Add(staff);
            realContext.SaveChanges();
            return RedirectToAction("Index");
            
        }

    }
}