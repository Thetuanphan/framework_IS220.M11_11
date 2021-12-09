using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class TaiKhoan
    {
        string tenDangNhap;
        string matKhau;
        string quyen;
        public TaiKhoan(string tenDangNhap, string matKhau,string quyen)
        {
            this.tenDangNhap = tenDangNhap;
            this.matKhau = matKhau;
            this.quyen = quyen;
        }

        public TaiKhoan()
        {
        }

        [Key]
        [Required(ErrorMessage = "Trường này không được trống")]
        [Display(Name = "Tên đăng nhập")]
        [StringLength(10, ErrorMessage = "Tên đăng nhập phải dưới 10 ký tự")]
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        [Required(ErrorMessage = "Trường này không được trống")]
        [Display(Name = "Mật khẩu")]
        [StringLength(20, ErrorMessage = "Mật khẩu phải dưới 20 ký tự")]
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string Quyen { get => quyen; set => quyen = value; }
    }
}
