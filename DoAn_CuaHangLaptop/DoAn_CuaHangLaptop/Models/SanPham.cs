using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class SanPham
    {
        string maSP;
        string tenSP;
        int soLuong;
        string mauSac;
        string cPU;
        string rAM;
        string oCung;
        string manHinh;
        string cardMH;
        string congKN;
        string dacBiet;
        string hDH;
        string thietKe;
        string kichThuoc_TrongLuong;
        string webcam;
        string pin;
        int raMat;
        string moTa;
        long donGia;
        string hinhAnh;
        string danhMuc;

        public SanPham()
        {
        }

        public SanPham(string maSP, string tenSP, int soLuong, string mauSac, string cPU, string rAM, string oCung, string manHinh, string cardMH, string congKN, string dacBiet, string hDH, string thietKe, string kichThuoc_TrongLuong, string webcam, string pin, int raMat, string moTa, long donGia, string hinhAnh, string danhMuc)
        {
            this.MaSP = maSP;
            this.TenSP = tenSP;
            this.SoLuong = soLuong;
            this.MauSac = mauSac;
            this.CPU = cPU;
            this.RAM = rAM;
            this.OCung = oCung;
            this.ManHinh = manHinh;
            this.CardMH = cardMH;
            this.CongKN = congKN;
            this.DacBiet = dacBiet;
            this.HDH = hDH;
            this.ThietKe = thietKe;
            this.KichThuoc_TrongLuong = kichThuoc_TrongLuong;
            this.Webcam = webcam;
            this.Pin = pin;
            this.RaMat = raMat;
            this.MoTa = moTa;
            this.DonGia = donGia;
            this.HinhAnh = hinhAnh;
            this.DanhMuc = danhMuc;
        }

        [Key]
        [Display(Name = "Mã sản phẩm")]
        public string MaSP { get => maSP; set => maSP = value; }
        [Required]
        [Display(Name = "Tên sản phẩm")]
        public string TenSP { get => tenSP; set => tenSP = value; }
        [Required]
        [Display(Name = "Số lượng")]
        public int SoLuong { get => soLuong; set => soLuong = value; }
        [Required]
        [Display(Name = "Màu sắc")]
        public string MauSac { get => mauSac; set => mauSac = value; }
        [Required]
        [Display(Name = "CPU")]
        public string CPU { get => cPU; set => cPU = value; }
        [Required]
        [Display(Name = "RAM")]
        public string RAM { get => rAM; set => rAM = value; }
        [Required]
        [Display(Name = "Ổ cứng")]
        public string OCung { get => oCung; set => oCung = value; }
        [Required]
        [Display(Name = "Màn hình")]
        public string ManHinh { get => manHinh; set => manHinh = value; }
        [Required]
        [Display(Name = "Card màn hình")]
        public string CardMH { get => cardMH; set => cardMH = value; }
        [Required]
        [Display(Name = "Cổng kết nối")]
        public string CongKN { get => congKN; set => congKN = value; }
        [Required]
        [Display(Name = "Đặc biệt")]
        public string DacBiet { get => dacBiet; set => dacBiet = value; }
        [Required]
        [Display(Name = "Hệ điều hành")]
        public string HDH { get => hDH; set => hDH = value; }
        [Required]
        [Display(Name = "Thiết kế")]
        public string ThietKe { get => thietKe; set => thietKe = value; }
        [Required]
        [Display(Name = "Kích thước - Trọng lượng")]
        public string KichThuoc_TrongLuong { get => kichThuoc_TrongLuong; set => kichThuoc_TrongLuong = value; }
        [Required]
        [Display(Name = "Webcam")]
        public string Webcam { get => webcam; set => webcam = value; }
        [Required]
        [Display(Name = "Pin")]
        public string Pin { get => pin; set => pin = value; }
        [Required]
        [Display(Name = "Ra mắt")]
        public int RaMat { get => raMat; set => raMat = value; }
        [Required]
        [Display(Name = "Mô tả")]
        public string MoTa { get => moTa; set => moTa = value; }
        [Required]
        [Display(Name = "Đơn giá")]
        public long DonGia { get => donGia; set => donGia = value; }
        [Required]
        [Display(Name = "Hình ảnh")]
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        [Required]
        [Display(Name = "Danh mục")]
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
    }
}