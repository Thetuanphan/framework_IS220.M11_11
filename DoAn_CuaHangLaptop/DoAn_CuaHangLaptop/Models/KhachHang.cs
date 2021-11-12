using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class KhachHang
    {
        string maKH;
        string tenDN;
        string tenKH;
        string soDT;
        string email;
        string gioiTinh;

        public KhachHang() { }

        public KhachHang(string maKH, string tenDN, string tenKH, string soDT, string email, string gioiTinh)
        {
            this.MaKH = maKH;
            this.TenDN = tenDN;
            this.TenKH = tenKH;
            this.SoDT = soDT;
            this.Email = email;
            this.GioiTinh = gioiTinh;
        }
        [Key]
        public string MaKH { get => maKH; set => maKH = value; }
        [Display(Name = "Tên Khách Hàng")]
        [StringLength(20, ErrorMessage = "Tên khách hàng phải dưới 20 ký tự")]
        public string TenKH { get => tenKH; set => tenKH = value; }
        public string TenDN { get => tenDN; set => tenDN = value; }
        [Phone(ErrorMessage ="Mật khẩu không đúng yêu cầu")]
        [Display(Name = "Số Điện thoại")]
        [StringLength(10, ErrorMessage = "Số điện thoại phải dưới 10 ký tự")]
        public string SoDT { get => soDT; set => soDT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string Email { get => email; set => email = value; }


    }
}
