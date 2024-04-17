using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TropicTrail.Utils;

namespace TropicTrail.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ManageOffers()
        {
            return View();
        }
        public ActionResult AddOffers()
        {
            ViewBag.TourType = Utilities.SelectListItemTourTypeByUser(Username);
            return View();
        }
        [HttpPost]
        public ActionResult AddOffers(Offers offers)
        {
            ViewBag.TourType = Utilities.SelectListItemTourTypeByUser(Username);

            var offersgUid = $"Offers-{Utilities.gUid}";

            offers.status = 1;
            offers.dateCreated = DateTime.Now;
            offers.offersgUId = offersgUid;
            offers.userId = UserId;

            if (_offersManager.CreateOffers(offers, ref ErrorMessage) == ErrorCode.Error)
            {
                ModelState.AddModelError(String.Empty, ErrorMessage);
                return View(offers);
            }
            TempData["Message"] = $"Product {offers.offersName} added!";
            return RedirectToAction("Index");
        }
    }
}