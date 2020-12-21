using LscServices;
using LscWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace LscWebApp.Controllers
{
    public class HomeController : Controller
    {
        private  readonly IGetEmployeeData _getEmployeeData;
        private readonly ISaveEmployeeData _saveEmployeeData;

        public HomeController(IGetEmployeeData getEmployeeData, ISaveEmployeeData saveEmployeeData)
        {
            _getEmployeeData = getEmployeeData;
            _saveEmployeeData = saveEmployeeData;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult SaveData()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult InsertEmployeeData()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ShowData()
        {
            List<EmployeeDataModel> models;
            models = _getEmployeeData.GetAllEmployeeData();

            return View(models);
        }

        [HttpPost]
        public IActionResult InsertEmployeeData(EmployeeDataModel model)
        {
            _saveEmployeeData.SaveAllEmployeeData(model);

            return RedirectToAction("SaveData", "Home");
        }
    }
}
