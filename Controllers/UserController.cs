using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LoginRegistration.Models;

namespace LoginRegistration.Controllers
{
    public class UserController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {            
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpPost("registration")]
        public IActionResult Registration(RegUser regUser)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View("Index");
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            return View();
        }
    }
}
