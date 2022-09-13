﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TruYumCaseStudyMVC.Models;

namespace TruYumCaseStudyMVC.Controllers
{
    public class MenuItemsController : Controller
    {
        private readonly TruYumContext _context;

        public MenuItemsController(TruYumContext context)
        {
            _context = context;
        }

        public ActionResult Index(bool? isAdmin)
        {
            var model = _context.MenuItems.Include(m => m.Category).ToList();

            if (isAdmin == true)
            {
                return View("IndexAdmin", model);
            }

            return View(model);
        }

        public ActionResult Admin()
        {
            return RedirectToAction("Index", "MenuItems", new { isAdmin = true });
        }

        public ActionResult Create()
        {
            var viewModel = new MenuItemViewModel()
            {
                Categories = _context.Categories.ToList()
            };

            return View("MenuItemForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var menuItem = _context.MenuItems.Find(id);
            if (menuItem is null) { return View("Error"); }

            var viewModel = new MenuItemViewModel()
            {
                MenuItem = menuItem,
                Categories = _context.Categories.ToList()
            };

            return View("MenuItemForm", viewModel);
        }

        [HttpPost]
        public ActionResult Modify(MenuItem menuItem)
        {
            if (menuItem.Id == 0)
            {
                _context.MenuItems.Add(menuItem);
            }
            else
            {
                var menuIteminDb = _context.MenuItems.Find(menuItem.Id);

                if (menuIteminDb is null) { return View("Error"); }

                menuIteminDb.Name = menuItem.Name;
                menuIteminDb.Price = menuItem.Price;
                menuIteminDb.Active = menuItem.Active;
                menuIteminDb.DateOfLaunch = menuItem.DateOfLaunch;
                menuIteminDb.CategoryId = menuItem.CategoryId;
                menuIteminDb.FreeDelivery = menuItem.FreeDelivery;
            }
            _context.SaveChanges();

            return RedirectToAction("Admin", "MenuItems");
        }
    }
}
