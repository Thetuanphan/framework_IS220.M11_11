using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class SuKien
    {
        string maSK;
        string tenSK;
        int phanTramGiamGia;
        DateTime ngayBD;
        DateTime ngayKT;

        public SuKien() { }
        public SuKien(string maSK, string tenSK, int phanTramGiamGia, DateTime ngayBD, DateTime ngayKT)
        {
            this.maSK = maSK;
            this.tenSK = tenSK;
            this.phanTramGiamGia = phanTramGiamGia;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }
        [Key]
        [Display(Name = "Mã sự kiện")]
        public string MaSK { get => maSK; set => maSK = value; }
        [Display(Name = "Tên sự kiện")]
        public string TenSK { get => tenSK; set => tenSK = value; }
        [Display(Name = "Phần trăm giảm giá")]
        public int PhanTramGiamGia { get => phanTramGiamGia; set => phanTramGiamGia = value; }
        [Display(Name = "Ngày bắt đầu sự kiện")]
        //[DisplayFormat(DataFormatString = "{dd-MM-yyyy 0:00:00 }", ApplyFormatInEditMode = true)]
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        [Display(Name = "Ngày kết thúc sự kiện")]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
    }
}
