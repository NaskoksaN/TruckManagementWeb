﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TruckManagementWeb.Core.Contracts;
using TruckManagementWeb.Core.Models.SoldOrder;

namespace TruckManagementWeb.Controllers
{
    [Authorize(Roles = "Dispo, Manager")]
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

            //string confirmationUrl = Url.Action("ConfirmOrder", "SellOrder", new { token = formModel.OrderGuid }, Request.Scheme);
            string confirmationUrl = Url.Action("Index", "Link", new { token = formModel.OrderGuid }, Request.Scheme);

            string emailContent = $"Find your order clicking the following link: <a href=\"{confirmationUrl}\">Update Order</a>";
            string mailSubject = $"Find Your Order details {formModel.LoadingTown} to {formModel.DeliveryTown}";

            mailService.SendMail(formModel.ClientEmail, emailContent, mailSubject);

            return RedirectToAction(nameof(OrderDetails), new {id = soldOrderId });
        }

        public async Task<IActionResult> OrderDetails(int id)
        {
            SoldViewFomrModel model = await sellOrderService.GetSoldOrderByIdAsync(id);
            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ConfirmOrder(Guid token)
        {
            SoldViewFomrModel model = await sellOrderService.GetOrderByTokeAsync(token);
            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ConfirmLoading(Guid token, DateTime? loadingDate)
        {
            var order = await sellOrderService.GetOrderByTokeAsync(token);
            if (order == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View("ConfirmOrderDetails", order);
            }

            order.LoadingDateTime = loadingDate;

            await sellOrderService.AddDateAsync(token, loadingDate, "loaded");

            return RedirectToAction(nameof(ConfirmOrder), new { token = token });
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ConfirmDelivery(Guid token, DateTime deliveryDate)
        {
            var order = await sellOrderService.GetOrderByTokeAsync(token);
            if (order == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View("ConfirmOrderDetails", order);
            }

            order.LoadingDateTime = deliveryDate;

            await sellOrderService.AddDateAsync(token, deliveryDate, "delivered");

            return RedirectToAction(nameof(ConfirmOrder), new { token = token });
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file, Guid token)
        {
            if (file == null || file.Length == 0)
            {
                ModelState.AddModelError("file", "Please select a file to upload.");
                return RedirectToAction("ConfirmOrder", new { token = token });
            }

            return RedirectToAction("ConfirmationPage");
        }
    }
}
