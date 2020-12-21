using LscWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LscWebApp
{
    public interface ISaveEmployeeData
    {
       void SaveAllEmployeeData(EmployeeDataModel employeeDataModel);
    }
}
