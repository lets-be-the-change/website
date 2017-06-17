using InstamojoAPI;
using LbtcWebsite.Models;
using LbtcWebsite.Secrets;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LbtcWebsite.Controllers
{
    public class DonateController : Controller
    {
        // GET: Donate
        public ActionResult EnterAmount()
        {
            var user = HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>().FindByNameAsync(User.Identity.Name).Result;

            if (user != null)
            {
                DonationAmountViewModel viewModel = new DonationAmountViewModel
                {
                    Amount = 100,
                    Email = user.Email,
                    PhoneNumber = user.PhoneNumber,
                    Name = user.Name
                };

                return View(viewModel);
            }

            return View();
        }

        [HttpPost]
        public ActionResult EnterAmount(DonationAmountViewModel userInput)
        {
            Instamojo objClass = InstamojoImplementation.getApi(PaymentGatewaySecrets.CLIENT_ID,
                PaymentGatewaySecrets.CLIENT_SECRET, PaymentGatewaySecrets.API_ENDPOINT,
                PaymentGatewaySecrets.AUTH_ENDPOINT);
            PaymentOrder objPaymentRequest = new PaymentOrder()
            {
                name = userInput.Name,
                email = userInput.Email,
                phone = userInput.PhoneNumber,
                amount = userInput.Amount,
                transaction_id = Guid.NewGuid().ToString(),
                redirect_url = "http://localhost:59701/Donate/PaymentMade"
            };

            if (objPaymentRequest.validate())
            {
                if (objPaymentRequest.emailInvalid)
                {
                    ModelState.AddModelError("", "Email is invalid");
                }
                if (objPaymentRequest.nameInvalid)
                {
                    ModelState.AddModelError("", "Name is invalid");
                }
                if (objPaymentRequest.phoneInvalid)
                {
                    ModelState.AddModelError("", "Phone Number is invalid");
                }
                if (objPaymentRequest.amountInvalid)
                {
                    ModelState.AddModelError("", "Amount is invalid");
                }
                if (objPaymentRequest.currencyInvalid)
                {
                    ModelState.AddModelError("", "Currency is invalid");
                }
                if (objPaymentRequest.transactionIdInvalid)
                {
                    ModelState.AddModelError("", "Transaction ID is invalid");
                }
                if (objPaymentRequest.redirectUrlInvalid)
                {
                    ModelState.AddModelError("", "URL is invalid");
                }
                if (objPaymentRequest.webhookUrlInvalid)
                {
                    ModelState.AddModelError("", "Webhook is invalid");
                }
            }
            else
            {
                CreatePaymentOrderResponse objPaymentResponse = objClass.createNewPaymentRequest(objPaymentRequest);
                return Redirect(objPaymentResponse.payment_options.payment_url);
            }

            return View();
        }

        public ActionResult PaymentMade(string id, string transaction_id, string payment_id)
        {
            ViewBag.Id = id;
            ViewBag.TransactionId = transaction_id;
            ViewBag.PaymentId = payment_id;
            return View();
        }
    }
}