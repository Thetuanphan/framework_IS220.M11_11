using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DoAn_CuaHangLaptop.Models
{
    public class HoaDon
    {
        string maHD;
        string maKH;
        string maNV;
        string maSK;
        string ngayHD;
        string diaChiGiaoHang;
        long tongTien;
        long thanhTien;

        public HoaDon()
        {
        }

        public HoaDon(string maHD, string maKH, string maNV, string maSK, string ngayHD, string diaChiGiaoHang, long tongTien, long thanhTien)
        {
            this.maHD = maHD;
            this.maKH = maKH;
            this.maNV = maNV;
            this.maSK = maSK;
            this.ngayHD = ngayHD;
            this.diaChiGiaoHang = diaChiGiaoHang;
            this.tongTien = tongTien;
            this.thanhTien = thanhTien;
        }

        [Key]
        [Display(Name = "Mã hóa đơn")]
        public string MaHD { get => maHD; set => maHD = value; }
        [Required]
        [Display(Name = "Mã khách hàng")]
        public string MaKH { get => maKH; set => maKH = value; }
        [Required]
        [Display(Name = "Mã khách hàng")]
        public string MaNV { get => maNV; set => maNV = value; }
        [Required]
        [Display(Name = "Mã sự kiện")]
        public string MaSK { get => maSK; set => maSK = value; }
        [Display(Name = "Ngày tạo hóa đơn")]
        [DisplayFormat(DataFormatString ="{0:dd-MM-yyyy}", ApplyFormatInEditMode =true)]
        public string NgayHD { get => ngayHD; set => ngayHD = value; }
        [Display(Name = "Địa chỉ giao hàng")]
        public string DiaChiGiaoHang { get => diaChiGiaoHang; set => diaChiGiaoHang = value; }
        [Display(Name = "Tổng tiền")]
        public long TongTien { get => tongTien; set => tongTien = value; }
        [Display(Name = "Thành tiền")]
        public long ThanhTien { get => thanhTien; set => thanhTien = value; }


    }


}
