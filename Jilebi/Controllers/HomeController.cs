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
            string empResult = _emp.GetEmployeeName(1);
            List<EmployeeDomainModel> EmpDomainList = _emp.getAllEmployeesList();
            List<EmployeeViewModel> empViewList = new List<EmployeeViewModel>();
            AutoMapper.Mapper.Map(EmpDomainList,empViewList);
            ViewBag.test = empResult;
            ViewBag.empList = empViewList;
            return View();
        }
    }
}