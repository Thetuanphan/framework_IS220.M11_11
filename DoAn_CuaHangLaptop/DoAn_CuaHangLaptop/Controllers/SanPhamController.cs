using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DoAn_CuaHangLaptop.Models;

namespace DoAn_CuaHangLaptop.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
           
            return View(context.LayDSSanPham());
        }
        public IActionResult Shop(int page,string madm)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            List<SanPham> spList = new List<SanPham>() ;
            double totalPage;
            if (string.IsNullOrEmpty(madm))
            {
                spList = context.LayDSSanPham();
                float temp = spList.Count() / (float)12;
                totalPage = Math.Ceiling(temp);
                if (page == 0)
                {
                    spList = spList.Take(12).ToList();
                }
                else
                {
                    spList = context.LayDSSPTheoTrang(page);
                }
            }
            else
            {
                spList = context.LayDSSPTheoDanhMuc(madm);
                float temp = spList.Count() / (float)12;
                totalPage = Math.Ceiling(temp);
                if (page == 0)
                {
                    spList = spList.Take(12).ToList();
                }
                else
                {
                    spList = context.LayDSSPTheoDanhMucTheoTrang(madm,page);
                }
            }

            ViewBag.dmSP = context.LayDSDanhMuc();
            ViewBag.dsSP = spList;
            ViewBag.totalPage = totalPage ;
            ViewBag.pageCurrent = page;
            return View();
            
        }
        public ActionResult ProductSingle(string masp)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            SanPham sp = context.LaySanPham(masp);
            ViewData["BXL"] = context.LayBoXuLy(sp.BoXuLy);
            ViewData["RAM"]= context.LayBoNhoRAM(sp.RAM);
            ViewData["MH"]= context.LayManHinh(sp.ManHinh);
            ViewData["CKN"] = context.LayCongKetNoi(sp.CongKN); 
            ViewData["SanPham"] = sp;
            return View();
        }
        

        [HttpGet]
        public ActionResult Create()
        {
            var model = new SanPham();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SanPham sp)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;

            if (context.TaoSanPham(sp) != 0)
            {
                return Redirect("/SanPham/Index");
            }
            return Redirect("/SanPham/Index");
        }

        public ActionResult Details(string id)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            ViewData["SanPham"] = context.LaySanPham(id);
            return View();
        }

        public ActionResult Edit(string id)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            ViewData["SanPham"] = context.LaySanPham(id);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, SanPham sp)
        {

            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            if (context.CapNhatSanPham(sp) != 0)
            {
                return Redirect("/SanPham/Index");
            }
            return Redirect("/SanPham/Index");
        }

        public ActionResult Delete(string id)
        {
            LapTopContext context = HttpContext.RequestServices.GetService(typeof(DoAn_CuaHangLaptop.Models.LapTopContext)) as LapTopContext;
            ViewData["SanPham"] = context.LaySanPham(id);
            if (context.XoaSanPham(id) != 0)
            {
                return Redirect("/SanPham/Index");
            }
            return Redirect("/SanPham/Index");
        }
    }
}
