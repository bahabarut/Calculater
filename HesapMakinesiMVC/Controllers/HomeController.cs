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
        public IActionResult OldProcess() => View();
        public JsonResult GetData(DateTime? start, DateTime? end, string? process)
        {
            Expression<Func<Entities.Process, bool>> condition;
            condition = (x =>
                 (start != null ? x.CreatedDate >= start : true) &&
                 (end != null ? x.CreatedDate <= end : true) &&
                 (process != null ? x.ProcessType == process : true)
            );
            var data = pm.GetList(condition).Select(x => new { createdDate = x.CreatedDate.ToShortDateString(), number1 = x.Number1, number2 = x.Number2, processId = x.ProcessId, processType = x.ProcessType, result = x.Result });
            return Json(data);
        }
        public IActionResult AddProcess(Entities.Process process)
        {
            process.CreatedDate = DateTime.Now.Date;
            pm.Add(process);
            return Json(new { success = true, message = "Ýþlem Baþarýlý" });
        }
        public IActionResult Privacy()
        {
            return View();
        }


    }
}
