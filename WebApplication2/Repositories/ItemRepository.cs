using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public class ItemRepository
    {
        private restaurantDBEntities1 objrestaurantDBEntities;
        public ItemRepository()
        {
            objrestaurantDBEntities = new restaurantDBEntities1();
        }
        public IEnumerable<SelectListItem> GetAllItems()
        {
            IEnumerable<SelectListItem> objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objrestaurantDBEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemId.ToString(),
                                      Selected = false
                                  }
                                  ).ToList();

            return objSelectListItems;
        }
    }
}