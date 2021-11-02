using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaSP { get => maSP; set => maSP = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

    }
}
