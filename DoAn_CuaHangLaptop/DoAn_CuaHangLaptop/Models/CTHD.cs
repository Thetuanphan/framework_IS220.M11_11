using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DoAn_CuaHangLaptop.Models
{
    public class CTHD
    {
        string maHD;
        string maSP;
        int soLuong;

        public CTHD(string maHD, string maSP, int soLuong)
        {
            this.maHD = maHD;
            this.maSP = maSP;
            this.soLuong = soLuong;
        }

        [Key]
        [Display(Name ="Mã hóa đơn")]
        public string MaHD { get => maHD; set => maHD = value; }
        [Key]
        [Display(Name = "Mã sản phẩm")]
        public string MaSP { get => maSP; set => maSP = value; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
