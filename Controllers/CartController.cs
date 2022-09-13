using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruYumCaseStudyMVC.Models;

namespace TruYumCaseStudyMVC.Controllers
{
    public class CartController : Controller
    {
        private readonly TruYumContext _context;

        public CartController(TruYumContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var cart = _context.Carts.Include(m => m.MenuItems).SingleOrDefault();

            if (cart is null)
            {
                var newCart = new Cart()
                {
                    MenuItems = new List<MenuItem>(),
                   
                };
                _context.Carts.Add(newCart);
                _context.SaveChanges();

                cart = newCart;
            }

            if (cart.MenuItems.Count == 0) { return View("EmptyCart"); }

            return View(cart);
        }

        public ActionResult AddToCart(int id)
        {
            var cartInDb = _context.Carts.Include(m => m.MenuItems).SingleOrDefault();
            var menuItem = _context.MenuItems.Find(id);

            if (menuItem is null) { return View("Error"); }
            
            
                cartInDb.MenuItems.Add(menuItem);
                _context.SaveChanges();
            
            return View("AddToCartSuccess");
        }

        public ActionResult Delete(int id)
        {
            var cartInDb = _context.Carts.Include(m => m.MenuItems).SingleOrDefault();
            var menuItem = _context.MenuItems.Find(id);

            if (menuItem is null) { return View("Error"); }
            if (!cartInDb.MenuItems.Contains(menuItem)) { return View("Error"); }

            cartInDb.MenuItems.Remove(menuItem);
            _context.SaveChanges();

            return RedirectToAction("Index", "Cart");
        }
    }
}
