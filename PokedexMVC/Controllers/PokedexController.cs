﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PokedexMVC.Web.Controllers
{
    public class PokedexController : Controller
    {
        // GET: PokedexController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PokedexController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PokedexController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PokedexController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokedexController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PokedexController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PokedexController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PokedexController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
