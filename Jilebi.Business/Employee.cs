﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jilebi.Domain;
using Jilebi.Repository;
using Jilebi.Repository.Infrastructure.Contract;
using Jilebi.Repository.Repositories;

namespace Jilebi.Business
{
    public class Employee : IEmployee
    {
        //public Employee(int x)
        //{

        //}
        private readonly IUnitOfWork unitOfWork;
        private readonly EmployeeRepository empRepository;
        public Employee(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
            empRepository = new EmployeeRepository(unitOfWork);
        }
        public string GetEmployeeName(int EmpI)
        {
            return "i am from interfae employee";
        }
        public List<EmployeeDomainModel> getAllEmployeesList()
        {
            List<EmployeeDomainModel> list = empRepository.GetAll().Select(m => new EmployeeDomainModel
            {
                EmpId = m.EmpId,
                Name = m.Name,
                Address = m.Address,
                DepartmentName = m.Department.DepartmentName

            }).ToList();
            ////////////JilebiDBEntities jilebiContext = new JilebiDBEntities();

            ////////////List<EmployeeDomainModel> list = jilebiContext.Employees.Select(m => new EmployeeDomainModel
            ////////////{
            ////////////    EmpId = m.EmpId,
            ////////////    Name = m.Name,
            ////////////    Address = m.Address,
            ////////////    DepartmentName=m.Department.DepartmentName

            ////////////}).ToList();

            //List<EmployeeDomainModel> list = new List<EmployeeDomainModel>(); 
            //list.Add(new EmployeeDomainModel() { EmpId = 1, Name="Murali" });
            //list.Add(new EmployeeDomainModel() { EmpId = 2, Name="siva"});
            //list.Add(new EmployeeDomainModel() { EmpId = 3, Name = "Valli" });
            //list.Add(new EmployeeDomainModel() { EmpId = 4, Name = "Rani" });
            //list.Add(new EmployeeDomainModel() { EmpId = 5, Name = "Bhavani" });
            //list.Add(new EmployeeDomainModel() { EmpId = 6, Name = "Paidi" });
            //list.Add(new EmployeeDomainModel() { EmpId = 7, Name = "Nagu" });
            //list.Add(new EmployeeDomainModel() { EmpId = 8, Name = "Sathwiq" });

            return list;
        }


    }
}

