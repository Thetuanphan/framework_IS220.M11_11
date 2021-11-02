using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaKH { get => maKH; set => maKH = value; }

    }

    
}
