using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class CongKetNoi
    {
        string maCKN;
        string congGiaoTiep;
        string ketNoiKhongDay;
        string kheDocTheNho;
        string webCam;
        string tinhNangKhac;
        string denBanPhim;

        public CongKetNoi()
        {
        }

        public CongKetNoi(string maCKN, string congGiaoTiep, string ketNoiKhongDay, string kheDocTheNho, string webCam, string tinhNangKhac, string denBanPhim)
        {
            this.MaCKN = maCKN;
            this.CongGiaoTiep = congGiaoTiep;
            this.KetNoiKhongDay = ketNoiKhongDay;
            this.KheDocTheNho = kheDocTheNho;
            this.WebCam = webCam;
            this.TinhNangKhac = tinhNangKhac;
            this.DenBanPhim = denBanPhim;
        }

        [Key]
        [Display(Name = "Mã cổng kết nối")]
        public string MaCKN { get => maCKN; set => maCKN = value; }
        [Required]
        [Display(Name = "Cổng giao tiếp")]
        public string CongGiaoTiep { get => congGiaoTiep; set => congGiaoTiep = value; }
        [Required]
        [Display(Name = "Kết nối không dây")]
        public string KetNoiKhongDay { get => ketNoiKhongDay; set => ketNoiKhongDay = value; }
        [Display(Name = "Khe đọc thẻ nhớ")]
        public string KheDocTheNho { get => kheDocTheNho; set => kheDocTheNho = value; }
        [Required]
        [Display(Name = "Webcam")]
        public string WebCam { get => webCam; set => webCam = value; }
        [Display(Name = "Tính năng khác")]
        public string TinhNangKhac { get => tinhNangKhac; set => tinhNangKhac = value; }
        [Required]
        [Display(Name = "Đèn bàn phím")]
        public string DenBanPhim { get => denBanPhim; set => denBanPhim = value; }
    }
}