using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PROG6212POE.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PROG6212POE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        // Home page method to return the view
        public IActionResult Index()
        {
            return View();
        }


        // Register 
        // This method reads the data taken from the user on the home page and then stores it into the database
        [HttpPost]
        public IActionResult Index(HomeLogin userData)
        {
            using (var db = new EntityContext())
            {
                db.Add(userData);
                db.SaveChanges();
            }
            return View();
        }

        // Login method to return the view 
        public IActionResult Login()
        {
            return View();
        }


        // Login View reads the database to see if the user is located 
        [HttpPost]
        public IActionResult Login(HomeLogin login)
        {
            using(var db = new EntityContext())
            {
                var userLocated = db.User.FirstOrDefault(user => user.Username == login.Username && user.Password == login.Password);
                if(userLocated != null)
                {
                    ViewBag.Message = "You have successfully logged in";
                }
                else
                {
                    ViewBag.Message = "Yoru details aren't found"; 
                }

            }

            return View();
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        // Add Module, Self Study, and Schedule views that are returned
        public IActionResult AddModule()
        {
            return View();
        }

        public IActionResult SelfStudyView()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }


        // this method ensures that whenever this method is called is links it to the Module view
        // and the data is saved to the database 
        [HttpPost]
        public IActionResult AddModule(ModuleModel modules)
        {
            using (var db = new EntityContext())
            {
                db.Add(modules);
                db.SaveChanges();
            }

            return View();
        }

        // this method ensures that whenever this method is called is links it to the Self Study view
        // and the data is saved to the database 
        [HttpPost]
        public IActionResult SelfStudyView(SelfStudyModel selfstudies)
        {
            using (var db = new EntityContext())
            {
                db.Add(selfstudies);
                db.SaveChanges();
            }

            return View();
        }


        // this method ensures that whenever this method is called is links it to the Schedule view
        // and the data is saved to the database 
        [HttpPost]
        public IActionResult Schedule(WeeklySchedule schedule)
        {
            using (var db = new EntityContext())
            {
                db.Add(schedule);
                db.SaveChanges();
            }

            return View();
        }





        

    }
}
