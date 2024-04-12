using HesapMakinesiMVC.Business.Concrete;
using HesapMakinesiMVC.DataAccess.Concrete;
using HesapMakinesiMVC.Entities;
using HesapMakinesiMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq.Expressions;
namespace HesapMakinesiMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ProcessManager pm = new ProcessManager(new ProcessDal());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OldProcess(DateTime? filterDate)
        {
            if (filterDate == null)
                return View(pm.GetList(null));
            else
                return Json(pm.GetList(x => x.CreatedDate == filterDate).Select(x => new { createdDate = x.CreatedDate.ToShortDateString(), number1 = x.Number1, number2 = x.Number2, processId = x.ProcessId, processType = x.ProcessType, result = x.Result }));
        }
        public IActionResult AddProcess(Entities.Process process)
        {
            process.CreatedDate = DateTime.Now.Date.AddDays(2);
            pm.Add(process);
            return Json(new { success = true, message = "Ýþlem Baþarýlý" });
        }
        public IActionResult Privacy()
        {
            return View();
        }


    }
}
