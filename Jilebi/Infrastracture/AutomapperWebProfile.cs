using Jilebi.Domain;
using Jilebi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Jilebi.Infrastracture
{
    public class AutomapperWebProfile : AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<EmployeeDomainModel, EmployeeViewModel>();

            //Reverse Mapping

            CreateMap<EmployeeViewModel, EmployeeDomainModel>();
        }
        public static void Run()
        {
            AutoMapper.Mapper.Initialize(
                a =>
                {
                    a.AddProfile<AutomapperWebProfile>();
                }
                );
        }

    }
}