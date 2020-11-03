using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class PaymentTypeRepository
    {
        private restaurantDBEntities1 objrestaurantDBEntities;
        public PaymentTypeRepository()
        {
            objrestaurantDBEntities = new restaurantDBEntities1();
        }
        public IEnumerable<SelectListItem> GetAllPaymentType()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objrestaurantDBEntities.PaymentTypes
                                  select new SelectListItem()
                                  {
                                      Text = obj.PaymentTypeName,
                                      Value = obj.PaymentTypeId.ToString(),
                                      Selected = true
                                  }
                                  ).ToList();

            return objSelectListItems;
        }
    }
}