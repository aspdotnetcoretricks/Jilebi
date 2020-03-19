using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jilebi.Business;
using Jilebi.Domain;
using Jilebi.Models;

namespace Jilebi.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        IEmployee _emp;

        //Oops Principles : depends on only on Abstraction not on concrete class
        //but if you give interface as parameter in HomeController constructor it doesnot work
        //to solve this problem use "Unity.MVC5"library, then the constructor works fine as per you by giving interface as parameter
        // in constructor
        //why we need to use directly concrete class should not use in business layer.
        //this controller is DI
        public HomeController(IEmployee emp)
        {
            _emp = emp;
        }
        public ActionResult Index()
        {
            return View();

        }

        public ActionResult GetEmployeeData()
        {
            List<EmployeeDomainModel> EmpDomainList = _emp.getAllEmployeesList();
            List<EmployeeViewModel> empViewList = new List<EmployeeViewModel>();
            AutoMapper.Mapper.Map(EmpDomainList, empViewList);
            return Json(new { data = empViewList }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]

        public ActionResult AddEditEmployee()
        {
            return View(new EmployeeViewModel());
        }

        [HttpPost]
        public ActionResult AddEditEmployee(EmployeeViewModel empView)
        {
            string result = "";
            empView.EmpId = empView.EmpId;
            empView.Name = empView.Name;
            empView.Address = empView.Address;
            empView.DeptId = empView.DeptId;
            EmployeeDomainModel empDoModel = new EmployeeDomainModel();
            AutoMapper.Mapper.Map(empView, empDoModel);
            result = _emp.AddEditEmp(empDoModel);

            return Json(new { success=true,message="Saved Successfully"}, JsonRequestBehavior.AllowGet);
           
        }

    }
}