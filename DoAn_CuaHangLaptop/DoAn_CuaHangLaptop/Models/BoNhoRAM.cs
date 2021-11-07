using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class BoNhoRAM
    {
        string maRAM;
        string dungLuongRAM;
        string loaiRAM;
        string busRAM;
        string hoTroToiDa;

        public BoNhoRAM()
        {
        }

        public BoNhoRAM(string maRAM, string dungLuongRAM, string loaiRAM, string busRAM, string hoTroToiDa)
        {
            this.MaRAM = maRAM;
            this.DungLuongRAM = dungLuongRAM;
            this.LoaiRAM = loaiRAM;
            this.BusRAM = busRAM;
            this.HoTroToiDa = hoTroToiDa;
        }

        [Key]
        [Display(Name = "Mã RAM")]
        public string MaRAM { get => maRAM; set => maRAM = value; }
        [Required]
        [Display(Name = "Dung lượng RAM")]
        public string DungLuongRAM { get => dungLuongRAM; set => dungLuongRAM = value; }
        [Required]
        [Display(Name = "Loại RAM")]
        public string LoaiRAM { get => loaiRAM; set => loaiRAM = value; }
        [Required]
        [Display(Name = "Bus RAM")]
        public string BusRAM { get => busRAM; set => busRAM = value; }
        [Required]
        [Display(Name = "Hỗ trợ tối đa")]
        public string HoTroToiDa { get => hoTroToiDa; set => hoTroToiDa = value; }
    }
}