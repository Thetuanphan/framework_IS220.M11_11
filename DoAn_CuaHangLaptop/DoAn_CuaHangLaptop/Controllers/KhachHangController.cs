using DoAn_CuaHangLaptop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Controllers
{
    public class KhachHangController : Controller
    {
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
        // GET: KhachHangController
        public IActionResult Index()
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            return View(context.layKhachHang());
        }
   /*     public ActionResult Index()
        {
            return View();
        }*/

        // GET: KhachHangController/Details/5
        public ActionResult Details(KhachHang kh)
        {
            return View(kh);
        }

        // GET: KhachHangController/Create
        public ActionResult Create()
        {
            var model = new KhachHang();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(KhachHang kh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            if (!ModelState.IsValid)
            {
                return View(kh);
            }
            kh.MatKhau = GetMD5(kh.MatKhau);
            int temp = context.taoKhachHang(kh);
            if (temp == 0)
            {
                ModelState.AddModelError("", "Tên đăng nhập đã tồn tại");
            }
            else if (temp == 1)
            {
                ModelState.AddModelError("", "Email đã tồn tại");
            }
            else
            {
                return RedirectToAction("Signin","TaiKhoan");
            }
            return View(kh);
        }
        // GET: KhachHangController/Edit/5
        public ActionResult Edit(string makh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
           /*ViewData["KhachHang"] = context.layKhachHang(makh);*/
            return View(context.layKhachHang(makh));
        }

        // POST: KhachHangController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(KhachHang kh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            //ViewBag.greet = makh;
            if(context.capNhatKhachHang(kh) == 0)
            {
                ModelState.AddModelError("", "Email đã tồn tại");
            }
            else
            {
                return Redirect("/KhachHang/Index");
            }
            return View(kh);
        }

        // GET: KhachHangController/Delete/5
        public ActionResult Delete(KhachHang kh)
        {
            /*LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            ViewData["KhachHang"] = context.layKhachHang(makh);*/
            return View(kh);
        }

        // POST: KhachHangController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string makh)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            //ViewBag.greet = makh;
            if (context.xoaKhachHang(makh)!=0)
            {
                return Redirect("/KhachHang/Index");
            }
            return Redirect("/KhachHang/Index");
            //return Redirect("Edit");
        }
    }
}
