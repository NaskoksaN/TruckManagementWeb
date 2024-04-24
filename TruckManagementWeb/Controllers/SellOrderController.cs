using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.SoldOrder;

namespace TruckManagementWeb.Controllers
{
    public class SellOrderController : Controller
    {
        private readonly IMyEmailService mailService;
        private readonly ISellOrder sellOrderService;
        private readonly ICompanyService companyService;

        public SellOrderController(IMyEmailService _mailService,
                                    ISellOrder _sellOrderService,
                                    ICompanyService _companyService)
        {
            mailService = _mailService;
            sellOrderService = _sellOrderService;
            companyService = _companyService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            SoldOrderFormModel formModel = new SoldOrderFormModel();
            return View(formModel);
        }
        [HttpPost]
        public async Task<IActionResult> Create(SoldOrderFormModel formModel)
        {
            string token = Guid.NewGuid().ToString();
            formModel.OrderGuid = Guid.Parse(token);

            if (await companyService.IsCompanyExistByVat(formModel.ClientCompanyVat) == false)
            {
                this.ModelState.AddModelError(nameof(formModel.ClientCompanyVat),
                     "Company with ths VAT was not found");
            }

            if (!ModelState.IsValid)
            {
                return View(formModel);
            }

            int soldOrderId = await sellOrderService.AddSoldOrderAsync(formModel);

            string confirmationUrl = Url.Action("ConfirmOrder", "SellOrder", new { token = formModel.OrderGuid }, Request.Scheme);

            string emailContent = $"Find your order clicking the following link: <a href=\"{confirmationUrl}\">Confirm Order</a>";
            string emailTitle = $"Find Your Order details {formModel.LoadingTown} to {formModel.DeliveryTown}";

            mailService.SendMail(formModel.ClientEmail, emailContent, emailTitle);

            return RedirectToAction(nameof(OrderDetails), new { id = soldOrderId });
        }

        public async Task<IActionResult> OrderDetails(int id)
        {
            SoldViewFomrModel model = await sellOrderService.GetSoldOrderByIdAsync(id);
            return View(model);
        }
        //[HttpGet]
        //public async Task<IActionResult> ConfirmOrder(Guid token)
        //{
        //    SoldViewFomrModel model = await sellingService.GetOrderByTokeAsync(token);
        //    return View(model);
        //}

        //[HttpPost]
        //public async Task<IActionResult> ConfirmLoading(Guid token, DateTime loadingDate)
        //{
        //    var order = await sellingService.GetOrderByTokeAsync(token);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }


        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return View("ConfirmOrderDetails", order); 
        //    //}

        //    order.LoadingDateTime = loadingDate;

        //    // Save changes to the database
        //    await sellingService.AddDateAsync(token, loadingDate, "loaded");

        //    // Redirect to the same page to reload the updated data
        //    return RedirectToAction(nameof(ConfirmOrder), new { token = token });
        //}
        //[HttpPost]
        //public async Task<IActionResult> ConfirmDelivery(Guid token, DateTime deliveryDate)
        //{
        //    var order = await sellingService.GetOrderByTokeAsync(token);
        //    if (order == null)
        //    {
        //        return NotFound();
        //    }


        //    //if (!ModelState.IsValid)
        //    //{
        //    //    return View("ConfirmOrderDetails", order); 
        //    //}

        //    order.LoadingDateTime = deliveryDate;

        //    // Save changes to the database
        //    await sellingService.AddDateAsync(token, deliveryDate, "delivered");

        //    // Redirect to the same page to reload the updated data
        //    return RedirectToAction(nameof(ConfirmOrder), new { token = token });
        //}
    }
}
