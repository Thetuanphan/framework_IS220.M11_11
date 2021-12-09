using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn_CuaHangLaptop.Models;
using System.Security.Cryptography;
using System.Text;

namespace DoAn_CuaHangLaptop.Controllers
{
    public class TaiKhoanController : Controller
    {
        //GET: LOGIN
        public IActionResult Signin()
        {
            return View();
        }
        //POST : LOGIN
        [HttpPost]
        public IActionResult Signin(TaiKhoan tk)
        {
            if (!ModelState.IsValid)
            {

                return View(tk);
            }
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            var callfunc = context.layThongTinTK(tk.TenDangNhap);
            if (context.ktTenDangNhap(tk.TenDangNhap))
            {
                ViewBag.error = "Tên đăng nhập không tồn tại";
                return View(tk);
            }
            else if (GetMD5(tk.MatKhau) == callfunc.MatKhau)
            {

                HttpContext.Session.SetString("usn", tk.TenDangNhap);
                HttpContext.Session.SetString("pwd", tk.MatKhau);
                if(callfunc.Quyen == "user")
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return LocalRedirect("/admin/Home/danhmuc");
                }
            }
            else
            {
                ViewBag.error = "Login failed";
                return RedirectToAction("Signin");
            }
        }

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

        // GET: TaiKhoanController

        //public IActionResult Index()
        //{
        //    LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
        //    ViewBag.dsTK = context.layDSTaiKhoan();
        //    return View();
        //}


        // GET: TaiKhoanController/Details/5
        //public ActionResult Details(string tendangnhap)
        //{
        //    LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
        //    return View(context.layThongTinTK(tendangnhap));
        //}

        // GET: TaiKhoanController/Create
        //public ActionResult Create()
        //{
        //    var model = new TaiKhoan();
        //    return View();
        //}

        // POST: TaiKhoanController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(TaiKhoan tk)
        //{

        //    LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
        //    if (!ModelState.IsValid)
        //    {
        //        return View(tk);
        //    }
        //    if (context.taoTaiKhoan(tk.TenDangNhap, tk.MatKhau) == 0)
        //    {
        //        ModelState.AddModelError("", "Tên tài khoản đã tồn tại");
        //    }
        //    else
        //    {
        //        TempData["AlertMessage"] = "Thêm thành công";
        //        TempData["AlertType"] = "alert alert-success";
        //        return RedirectToAction("Index");
        //    }


        //    return View(tk);
        //}


        // GET: TaiKhoanController/Edit/5
        public ActionResult Edit(string tendangnhap)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            var result = context.layThongTinTK(tendangnhap).MatKhau;
            if (string.IsNullOrEmpty(result))
            {
                return Content("");
            }
            return View(context.layThongTinTK(tendangnhap));
        }

        // POST: TaiKhoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string tendangnhap, TaiKhoan tk)
        {

            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
           
            if (context.capNhatTaiKhoan(tendangnhap, GetMD5(tk.MatKhau))!= 0)
            {
                TempData["AlertMessage"] = "Cập nhật thành công";
                TempData["AlertType"] = "alert alert-success";
                return RedirectToAction("Signin");
           
            }

            return View();
        }
        [HttpPost]
        public JsonResult timTaiKhoan(string tendangnhap)
        {

            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            var tk = context.layThongTinTK(tendangnhap);
            return Json(tk);
        }


        //POST: TaiKhoanController/Delete/5
        //[HttpPost]
        //public ActionResult Delete(string tendangnhap)
        //{
        //    try
        //    {
        //        LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
        //        context.xoaTaiKhoan(tendangnhap);
        //        TempData["AlertMessage"] = "Xóa thành công";
        //        TempData["AlertType"] = "alert alert-success";
        //        return RedirectToAction("Index");
        //    }
        //    catch (MySql.Data.MySqlClient.MySqlException ex)
        //    {
        //        TempData["AlertMessage"] = "Tồn tại người dùng có tài khoản này. Không thể xóa";
        //        TempData["AlertType"] = "alert alert-danger";
        //        return RedirectToAction("Index");

        //    }

        //}
    }
}
