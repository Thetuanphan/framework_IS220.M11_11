using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class BoXuLy
    {
        string maBXL;
        string congNgheCPU;
        int? soNhan;
        int? soLuong;
        string tocDoCPU;
        string tocDoToiDa;
        string boNhoDem;

        public BoXuLy()
        {
        }

        public BoXuLy(string maBXL, string congNgheCPU, int soNhan, int soLuong, string tocDoCPU, string tocDoToiDa, string boNhoDem)
        {
            this.MaBXL = maBXL;
            this.CongNgheCPU = congNgheCPU;
            this.SoNhan = soNhan;
            this.SoLuong = soLuong;
            this.TocDoCPU = tocDoCPU;
            this.TocDoToiDa = tocDoToiDa;
            this.BoNhoDem = boNhoDem;
        }

        [Key]
        [Display(Name = "Mã bộ xử lý")]
        public string MaBXL { get => maBXL; set => maBXL = value; }
        [Required]
        [Display(Name = "Công nghệ CPU")]
        public string CongNgheCPU { get => congNgheCPU; set => congNgheCPU = value; }
        [Required]
        [Display(Name = "Số nhân")]
        public int? SoNhan { get => soNhan; set => soNhan = value; }
        [Required]
        [Display(Name = "Số luồng")]
        public int? SoLuong { get => soLuong; set => soLuong = value; }
        [Required]
        [Display(Name = "Tốc độ CPU")]
        public string TocDoCPU { get => tocDoCPU; set => tocDoCPU = value; }
        [Required]
        [Display(Name = "Tốc độ tối đa")]
        public string TocDoToiDa { get => tocDoToiDa; set => tocDoToiDa = value; }
        [Required]
        [Display(Name = "Bộ nhớ đệm")]
        public string BoNhoDem { get => boNhoDem; set => boNhoDem = value; }
    }
}