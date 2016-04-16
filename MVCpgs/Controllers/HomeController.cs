using MVCpgs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using MVCpgs.Services;

namespace MVCpgs.Controllers
{
    public class HomeController : Controller
    {
        GmailEmailService _emailService;

        public HomeController()
        {
            _emailService = new GmailEmailService();
        }

        public ActionResult Index()
        { 
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(UserContact userContact)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            
            await _emailService.Send(userContact);

            return View("thanks", userContact);
        }
    }
}





