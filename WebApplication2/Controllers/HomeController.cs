using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private restaurantDBEntities1 objrestaurantDBEntities;
        public HomeController()
        {
            objrestaurantDBEntities = new restaurantDBEntities1();
        }
        //GET:Home
        public ActionResult Index()
        {
            CustomerRepository objCustomerRepository = new CustomerRepository();
            ItemRepository objItemRepository = new ItemRepository();
            PaymentTypeRepository objPaymentTypeRepository = new PaymentTypeRepository();

            var objMultipleModels  = new Tuple <IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable < SelectListItem >> 
                (objCustomerRepository.GetAllCustomer(), objItemRepository.GetAllItems(), objPaymentTypeRepository.GetAllPaymentType() );
            return View(objMultipleModels);
        }

        [HttpGet]
        public JsonResult GetItemUnitPrice(int itemId)
        {
            decimal UnitPrice = objrestaurantDBEntities.Items.Single(model => model.ItemId == itemId).ItemPrice;
            return Json(UnitPrice, JsonRequestBehavior.AllowGet);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}