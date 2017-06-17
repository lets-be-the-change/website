using InstamojoAPI;
using LbtcWebsite.Models;
using LbtcWebsite.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LbtcWebsite.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult GetDonations()
        {
            Instamojo objClass = InstamojoImplementation.getApi(PaymentGatewaySecrets.CLIENT_ID,
                PaymentGatewaySecrets.CLIENT_SECRET, PaymentGatewaySecrets.API_ENDPOINT,
                PaymentGatewaySecrets.AUTH_ENDPOINT);

            PaymentOrderListRequest objPaymentOrderListRequest = new PaymentOrderListRequest();

            PaymentOrderListResponse objPaymentRequestStatusResponse = objClass.getPaymentOrderList(objPaymentOrderListRequest);

            List<OrderViewModel> viewModel = new List<OrderViewModel>();
            foreach (var order in objPaymentRequestStatusResponse.orders)
            {
                viewModel.Add(new OrderViewModel
                {
                    Amount = order.amount,
                    CreatedAt = order.created_at,
                    Currency = order.currency,
                    Description = order.description,
                    Email = order.email,
                    Id = order.id,
                    Name = order.name,
                    Phone = order.phone,
                    RedirectUrl = order.redirect_url,
                    ResourceUri = order.resource_uri,
                    Status = order.status,
                    TransactionId = order.transaction_id,
                    WebhookUrl = order.webhook_url
                });
            }

            return View(viewModel);
        }

        public ActionResult ViewUsers()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var users = db.Users.ToList();
            return View(users);
        }
    }
}