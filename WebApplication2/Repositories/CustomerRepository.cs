using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class CustomerRepository
    {
        private restaurantDBEntities1 objrestaurantDBEntities;
        public CustomerRepository()
        {
            objrestaurantDBEntities = new restaurantDBEntities1();
        }
        public IEnumerable<SelectListItem> GetAllCustomer()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objrestaurantDBEntities.Customers
                                  select new SelectListItem()
                                  {
                                      Text = obj.CustomerName,
                                      Value = obj.CustomerId.ToString(),
                                      Selected = true
                                  }
                                  ).ToList();

            return objSelectListItems;
        }
    }
}