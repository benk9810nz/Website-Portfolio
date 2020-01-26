using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebsitePortfolio.Models;
namespace WebsitePortfolio.Controllers
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Resume()
        {
            return View();
        }
        public IActionResult Portfolio()
        {
            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Confirmation()
        {
            
            return View();
        }
        
        public IActionResult Contact()
        {
            return View();
        }
      
        public IActionResult Test()
        {
            return View();
        }

        // POST: ContactFormModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Contact([Bind("ContactID,Name,PhoneNumber,Email,Message")] ContactFormModel contactFormModel)
        {
            if (ModelState.IsValid)
            {
                SendEmail.Send(contactFormModel, 1);
                //return RedirectToAction("Confirmation");
                ViewBag.result = "Record Inserted Successfully!";
                return View();
            }

            return View(contactFormModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
