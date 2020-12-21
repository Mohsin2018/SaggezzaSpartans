using LscWebApp.Models;
using System.Collections.Generic;

namespace LscServices
{
    public interface IGetEmployeeData
    {
       List<EmployeeDataModel> GetAllEmployeeData();
    }
}
