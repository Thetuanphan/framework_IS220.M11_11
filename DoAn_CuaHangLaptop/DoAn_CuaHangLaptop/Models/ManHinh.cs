using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class ManHinh
    {
        string maMH;
        string kichThuoc;
        string doPhanGiai;
        string tanSoQuet;
        string congNgheMH;
        string camUng;

        public ManHinh()
        {
        }

        public ManHinh(string maMH, string kichThuoc, string doPhanGiai, string tanSoQuet, string congNgheMH, string camUng)
        {
            this.MaMH = maMH;
            this.KichThuoc = kichThuoc;
            this.DoPhanGiai = doPhanGiai;
            this.TanSoQuet = tanSoQuet;
            this.CongNgheMH = congNgheMH;
            this.CamUng = camUng;
        }

        [Key]
        [Display(Name = "Mã màn hình")]
        public string MaMH { get => maMH; set => maMH = value; }
        [Required]
        [Display(Name = "Kích thước")]
        public string KichThuoc { get => kichThuoc; set => kichThuoc = value; }
        [Required]
        [Display(Name = "Độ phân giải")]
        public string DoPhanGiai { get => doPhanGiai; set => doPhanGiai = value; }
        [Required]
        [Display(Name = "Tần số quét")]
        public string TanSoQuet { get => tanSoQuet; set => tanSoQuet = value; }
        [Required]
        [Display(Name = "Công nghệ màn hình")]
        public string CongNgheMH { get => congNgheMH; set => congNgheMH = value; }
        [Required]
        [Display(Name = "Cảm ứng")]
        public string CamUng { get => camUng; set => camUng = value; }
    }
}