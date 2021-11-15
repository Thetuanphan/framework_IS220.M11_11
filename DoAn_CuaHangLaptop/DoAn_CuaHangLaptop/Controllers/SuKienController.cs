﻿using DoAn_CuaHangLaptop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Controllers
{
    public class SuKienController : Controller
    {
        // GET: KhachHangController
        public IActionResult Index()
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            return View(context.laySuKien());
        }
        // GET: SuKienController
      /*  public ActionResult Index()
        {
            return View();
        }*/

        // GET: SuKienController/Details/5
        public ActionResult Details(SuKien sk)
        {
            return View(sk);
        }

        // GET: SuKienController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuKienController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SuKien sk)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            if (!ModelState.IsValid)
            {
                return View(sk);
            }

            if (context.taoSuKien(sk) != 0)
            {
                return Redirect("/SuKien/Index");
            }
            return Redirect("/SuKien/Index");
        }

        // GET: SuKienController/Edit/5
        public ActionResult Edit(SuKien sk)
        {
            return View(sk);
        }

        // POST: SuKienController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string makh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            //ViewBag.greet = makh;
            SuKien sk = context.laySuKien(makh);
            if (context.capNhatSuKien(sk) != 0)
            {
                return Redirect("/SuKien/Index");
            }
            return Redirect("/SuKien/Index");
        }

        // GET: SuKienController/Delete/5
        public ActionResult Delete(SuKien sk)
        {
            return View(sk);
        }

        // POST: SuKienController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string mask)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            //ViewBag.greet = makh;
            if (context.xoaSuKien(mask) != 0)
            {
                return Redirect("/SuKien/Index");
            }
            return Redirect("/SuKien/Index");
        }
    }
}
