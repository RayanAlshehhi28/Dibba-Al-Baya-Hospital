using AspNetCoreHero.ToastNotification.Abstractions;
using DibaHospital.Data;
using DibaHospital.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace DibaHospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DibaContext _context;
        private readonly INotyfService _notyf;

        public HomeController(ILogger<HomeController> logger, DibaContext context, INotyfService notyfService)
        {
            _logger = logger;
            _context = context;
            _notyf = notyfService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult About()
        {
            return View();
        }
  
        public IActionResult Career()
        {
            return View();
        }

        public IActionResult Training()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
      
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(model);
                _context.SaveChanges();

                _notyf.Success($"Dear {model.Name} your message has been send successfully");
            }
            else
            {
                _notyf.Error($"Error. Dear {model.Name} your message has not been send successfully");

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeAppointment(Appointment model)
        {
            if (ModelState.IsValid)
            {
                _context.Appointments.Add(model);
                _context.SaveChanges();

                _notyf.Success($"Dear {model.FullName} your appointment {model.AppointmentDate} for {model.AppointmentType} has been send successfully");
               // return RedirectToAction("Index", "Appointments");
               
            }
            else
            {
                _notyf.Warning($"Error. Dear {model.FullName} your appointment {model.AppointmentDate} for {model.AppointmentType} has not been send.");
            }
            return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}