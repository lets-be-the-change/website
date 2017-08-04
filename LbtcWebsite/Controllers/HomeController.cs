using LbtcWebsite.DAL;
using LbtcWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace LbtcWebsite.Controllers
{
    public class HomeController : Controller
    {
        private LbtcContext db = new LbtcContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Events = db.Events.ToList();
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ContactUs(ContactUsViewModel userInput)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var email = new MailMessage(new MailAddress("noreply@letsbethechange.in"),
                new MailAddress("info@letsbethechange.in "));
            email.Subject = "Contact Us Entry";
            email.Body = "Name = " + userInput.Name + "\nEmail = " + userInput.Email
                + "\nPhone Number = " + userInput.PhoneNumber + "\nMessage = " + userInput.Message;
            email.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                var credential = new NetworkCredential
                {
                    UserName = "noreply@letsbethechange.in",
                    Password = "Adithya_123"
                };
                smtp.Credentials = credential;
                smtp.Host = "smtpout.secureserver.net ";
                smtp.Port = 3535;
                smtp.EnableSsl = false;
                smtp.Timeout = 10000;
                smtp.Send(email);
            }

            return View();
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}