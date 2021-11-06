using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoAn_CuaHangLaptop.Models
{
    public class DanhMuc
    {
        string maDM;
        string tenDM;

        [Key]
        [Display(Name = "Mã danh mục")]
        public string MaDM { get => maDM; set => maDM = value; }
        [Required]
        [Display(Name = "Tên danh mục")]
        public string TenDM { get => tenDM; set => tenDM = value; }

        public DanhMuc()
        {
        }

        public DanhMuc(string maDM, string tenDM)
        {
            this.maDM = maDM;
            this.tenDM = tenDM;
        }
    }
}
