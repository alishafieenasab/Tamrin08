using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net;
using Tamrin08.Models;

namespace Tamrin08.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            PersonRepository personRepository = new PersonRepository();
            var persons = personRepository.GetAllPeople();
            return View(persons);
        }
        [HttpGet]
        public IActionResult Delete(string id)
        {
            PersonRepository personRepository = new PersonRepository();
            var persons = personRepository.GetAllPeople();
            var aPerson = persons.Where(x => x.Id == id).FirstOrDefault();
            return View(aPerson);
        }
        [HttpPost]
        public IActionResult AdmitDelete(string id)
        {
            PersonRepository personRepository = new PersonRepository();
            var persons = personRepository.GetAllPeople();
            var aPerson = persons.Where(x => x.Id == id).FirstOrDefault();
            persons.Remove(aPerson);
            return RedirectToAction("Contact");
        }
        public IActionResult Layout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}