using GrantsDinerAngularDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrantsDinerAngularDemo.Services
{
	public interface IDAL
	{
        IEnumerable<string> GetMenuCategories();
        MenuItem GetMenuItemDetail(int id);
        IEnumerable<MenuItem> GetMenuItems();
        IEnumerable<MenuItem> GetMenuItemsByCategory(string cat);
        IEnumerable<JoinedItem> GetCart(int id);
        int AddToCart(ShoppingCart cartItem);
        int DeleteFromCart(int id);
        int UpdateInCart(ShoppingCart item);
    }
}
