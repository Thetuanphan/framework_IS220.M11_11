using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace DoAn_CuaHangLaptop.Models
{
    public class LapTopContext
    {
        readonly IConfiguration configuration;
        public string ConnectionString { get; set; }

        public LapTopContext(string connectionString)
        {
            ConnectionString = connectionString;
        }

        MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
        // context khach hang
        public List<KhachHang> layKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from KhachHang";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new KhachHang()
                        {
                            MaKH = reader["makh"].ToString(),
                            TenDN = reader["tendangnhap"].ToString(),
                            TenKH = reader["tenKH"].ToString(),
                            SoDT = reader["soDT"].ToString(),
                            Email = reader["email"].ToString(),
                            GioiTinh = reader["gioiTinh"].ToString(),
                        });

                    }
                }
            }
            return list;
        }
        public int taoKhachHang(KhachHang kh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO laptop.`khachhang`(TENDANGNHAP,TENKH,SODT,EMAIL,GIOITINH)VALUES(?tendangnhap, ?tenkh, ?sodt, ?email, ?gioitinh);";
                //string query = "insert into khachhang value(?tendangnhap, ?tenkh, ?sodt, ?email, ?gioitinh) ";//ON DUPLICATE KEY UPDATE MaKH = ?makh
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("makh", kh.MaKH.ToString());
                cmd.Parameters.AddWithValue("tendangnhap", kh.TenDN.ToString());
                cmd.Parameters.AddWithValue("tenkh", kh.TenKH.ToString());
                cmd.Parameters.AddWithValue("sodt", kh.SoDT.ToString());
                cmd.Parameters.AddWithValue("email", kh.Email.ToString());
                cmd.Parameters.AddWithValue("gioitinh", kh.GioiTinh.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int capNhatKhachHang(KhachHang kh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string makh = kh.MaKH;
                string query = "update khachhang set tenkh=@Tenkh,tendangnhap=@Tendangnhap , sodt =@Sodt, email=@Email, gioitinh =@Gioitinh where makh = @makh";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", makh);
                cmd.Parameters.AddWithValue("@tendangnhap", kh.TenDN.ToString());
                cmd.Parameters.AddWithValue("makh", kh.MaKH.ToString());
                cmd.Parameters.AddWithValue("tenkh", kh.TenKH.ToString());
                cmd.Parameters.AddWithValue("sodt", kh.SoDT.ToString());
                cmd.Parameters.AddWithValue("email", kh.Email.ToString());
                cmd.Parameters.AddWithValue("gioitinh", kh.GioiTinh.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int xoaKhachHang(string makh)

        //test thử nè...

        //DANH MUC MODEL
        public List<DanhMuc> LayDSDanhMuc()
        {
            List<DanhMuc> list = new List<DanhMuc>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from DanhMucSanPham";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DanhMuc()
                        {
                            MaDM = reader["madm"].ToString(),
                            TenDM = reader["TenDM"].ToString(),
                        });

                    }
                }
            }
            return list;
        }

        public DanhMuc LayDanhMuc(string madm)
        {

            DanhMuc dm = new DanhMuc();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from DanhMucSanPham where madm =@madm";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@madm", madm);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        dm.MaDM = reader["madm"].ToString();
                        dm.TenDM = reader["tendm"].ToString();
                    }
                }
                return dm;
            }
        }

        public int TaoDanhMuc(DanhMuc dm)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into DanhMucSanPham value(?madm, ?tendm) ";//ON DUPLICATE KEY UPDATE madm = ?madm
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("madm", dm.MaDM.ToString());
                cmd.Parameters.AddWithValue("tendm", dm.TenDM.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int CapNhatDanhMuc(DanhMuc dm)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string madm = dm.MaDM;
                string query = "update DanhMucSanPham set tendm=@tendm where madm = @madm";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@madm", madm);
                cmd.Parameters.AddWithValue("madm", dm.MaDM.ToString());
                cmd.Parameters.AddWithValue("tendm", dm.TenDM.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int XoaDanhMuc(string madm)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from DanhMucSanPham where madm = @madm ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", madm); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        // BO NHO RAM MODEL
        public List<BoNhoRAM>   LayDSBoNhoRAM()
        {
            List<BoNhoRAM> list = new List<BoNhoRAM>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from BoNhoRAM";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BoNhoRAM()
                        {
                            MaRAM = reader["MARAM"].ToString(),
                            DungLuongRAM = reader["DUNGLUONGRAM"].ToString(),
                            LoaiRAM = reader["loairam"].ToString(),
                            BusRAM = reader["BUSRAM"].ToString(),
                            HoTroToiDa = reader["HOTROTOIDA"].ToString(),
                        });

                    }
                }
            }
            return list;
        }

        public BoNhoRAM LayBoNhoRAM(string maram)
        {

            BoNhoRAM BNR = new BoNhoRAM();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from BoNhoRAM where maram =@maram";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", maram);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BNR.MaRAM = reader["MARAM"].ToString();
                        BNR.DungLuongRAM = reader["DUNGLUONGRAM"].ToString();
                        BNR.LoaiRAM = reader["LOAIRAM"].ToString();
                        BNR.BusRAM = reader["HOTROTOIDA"].ToString();
                        BNR.HoTroToiDa = reader["email"].ToString();
                    };

                }
            }
            return BNR;
        }

        public int TaoBoNhoRAM(BoNhoRAM bnr)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into bonhoram value(?maram, ?dungluongram, ?loairam, ?busram, ?hotrotoida) ";//ON DUPLICATE KEY UPDATE maram = ?maram
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("maram", bnr.MaRAM.ToString());
                cmd.Parameters.AddWithValue("dungluongram", bnr.DungLuongRAM.ToString());
                cmd.Parameters.AddWithValue("loairam", bnr.LoaiRAM.ToString());
                cmd.Parameters.AddWithValue("busram", bnr.BusRAM.ToString());
                cmd.Parameters.AddWithValue("hotrotoida", bnr.HoTroToiDa.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int CapNhatBoNhoRAM(BoNhoRAM bnr)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string maram = bnr.MaRAM;
                string query = "update bonhoram set dungluongram=@dungluongram, loairam =@loairam, busram=@busram, hotrotoida =@hotrotoida where maram = @maram";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maram", maram);
                cmd.Parameters.AddWithValue("maram", bnr.MaRAM.ToString());
                cmd.Parameters.AddWithValue("dungluongram", bnr.DungLuongRAM.ToString());
                cmd.Parameters.AddWithValue("loairam", bnr.LoaiRAM.ToString());
                cmd.Parameters.AddWithValue("busram", bnr.BusRAM.ToString());
                cmd.Parameters.AddWithValue("hotrotoida", bnr.HoTroToiDa.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int XoaBoNhoRAM(string maram)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from bonhoram where maram = @maram ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maram", maram); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        //BO XU LY MODEL BoXuLy

        public List<BoXuLy> LayDSBoXuLy()
        {
            List<BoXuLy> list = new List<BoXuLy>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from BoXuLy";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new BoXuLy()
                        {
                            MaBXL = reader["MABXL"].ToString(),
                            CongNgheCPU = reader["CONGNGHECPU"].ToString(),
                            SoNhan = Convert.ToInt32(reader["SONHAN"]),
                            SoLuong = Convert.ToInt32(reader["SOLUONG"]),
                            TocDoCPU = reader["TocDoCPU"].ToString(),
                            TocDoToiDa = reader["TocDoToiDa"].ToString(),
                            BoNhoDem = reader["BoNhoDem"].ToString(),
                        });

                    }
                }
            }
            return list;
        }

        public BoXuLy LayBoXuLy(string mabxl)
        {

            BoXuLy BXL = new BoXuLy();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from boxuly where mabxl =@mabxl";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mabxl", mabxl);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BXL.MaBXL = reader["MABXL"].ToString();
                        BXL.CongNgheCPU = reader["CONGNGHECPU"].ToString();
                        BXL.SoNhan = Convert.ToInt32(reader["SONHAN"]);
                        BXL.SoLuong = Convert.ToInt32(reader["SOLUONG"]);
                        BXL.TocDoCPU = reader["TocDoCPU"].ToString();
                        BXL.TocDoToiDa = reader["TocDoToiDa"].ToString();
                        BXL.BoNhoDem = reader["BoNhoDem"].ToString();
                    };

                }
            }
            return BXL;
        }

        public int TaoBoXuLy(BoXuLy bxl)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into BoXuLy value(?mabxl, ?congnghecpu, ?sonhan, ?soluong, ?tocdocpu, ?tocdotoida, ?bonhodem) ";//ON DUPLICATE KEY UPDATE mabxl = ?mabxl
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("mabxl", bxl.MaBXL.ToString());
                cmd.Parameters.AddWithValue("congnghecpu", bxl.CongNgheCPU.ToString());
                cmd.Parameters.AddWithValue("sonhan", Convert.ToInt32(bxl.SoNhan));
                cmd.Parameters.AddWithValue("soluong", Convert.ToInt32(bxl.SoLuong));
                cmd.Parameters.AddWithValue("tocdocpu", bxl.TocDoCPU.ToString());
                cmd.Parameters.AddWithValue("tocdotoida", bxl.TocDoToiDa.ToString());
                cmd.Parameters.AddWithValue("bonhodem", bxl.BoNhoDem.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int CapNhatBoXuLy(BoXuLy bxl)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                //if (kh == null) return 0;
                conn.Open();
                string temp = makh;
                string query = "delete from khachhang where makh = @makh ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", temp); //Binding
                conn.Open();
                string mabxl = bxl.MaBXL;
                string query = "update BoXuLy set congnghecpu=@congnghecpu, sonhan =@sonhan, soluong=@soluong, tocdocpu =@tocdocpu, tocdotoida=@tocdotoida, bonhodem=@bonhodem where mabxl = @mabxl";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mabxl", mabxl);
                cmd.Parameters.AddWithValue("mabxl", bxl.MaBXL.ToString());
                cmd.Parameters.AddWithValue("congnghecpu", bxl.CongNgheCPU.ToString());
                cmd.Parameters.AddWithValue("sonhan", Convert.ToInt32(bxl.SoNhan));
                cmd.Parameters.AddWithValue("soluong", Convert.ToInt32(bxl.SoLuong));
                cmd.Parameters.AddWithValue("tocdocpu", bxl.TocDoCPU.ToString());
                cmd.Parameters.AddWithValue("tocdotoida", bxl.TocDoToiDa.ToString());
                cmd.Parameters.AddWithValue("bonhodem", bxl.BoNhoDem.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }
        public KhachHang layKhachHang(string makh)
        {

            KhachHang kh = new KhachHang();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string temp = makh;
                string query = "select * from KhachHang where makh =@makh";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@makh", temp);

        public int XoaBoXuLy(string mabxl)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from BoXuLy where mabxl = @mabxl ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mabxl", mabxl); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        //CONG KET NOI MODEL CongKetNoi
        /*create table CONGKETNOI
        (
           MACKN                char(5) not null,
           CONGGIAOTIEP varchar(200),
           KETNOIKHONGDAY varchar(100),
           KHEDOCTHENHO varchar(20),
           WEBCAM varchar(50),
           TINHNANGKHAC varchar(200),
           DENBANPHIM varchar(10),
           primary key(MACKN)
        ) DEFAULT CHARSET = utf8mb4;*/

        public List<CongKetNoi> LayDSCongKetNoi()
        {
            List<CongKetNoi> list = new List<CongKetNoi>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from CongKetNoi";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kh.MaKH = reader["makh"].ToString();
                        kh.TenDN = reader["tendangnhap"].ToString();
                        kh.TenKH = reader["tenKH"].ToString();
                        kh.SoDT = reader["soDT"].ToString();
                        kh.Email = reader["email"].ToString();
                        kh.GioiTinh = reader["gioiTinh"].ToString();
                        list.Add(new CongKetNoi()
                        {
                            MaCKN = reader["MACKN"].ToString(),
                            CongGiaoTiep = reader["CONGGIAOTIEP"].ToString(),
                            KetNoiKhongDay = reader["KETNOIKHONGDAY"].ToString(),
                            KheDocTheNho = reader["KHEDOCTHENHO"].ToString(),
                            WebCam = reader["WEBCAM"].ToString(),
                            TinhNangKhac = reader["TINHNANGKHAC"].ToString(),
                            DenBanPhim = reader["DENBANPHIM"].ToString(),
                        });

                    }
                }
            }
            return list;
        }

        public CongKetNoi LayCongKetNoi(string mackn)
        {

            CongKetNoi CKN = new CongKetNoi();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from CongKetNoi where mackn =@mackn";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mackn", mackn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CKN.MaCKN = reader["MACKN"].ToString();
                        CKN.CongGiaoTiep = reader["CONGGIAOTIEP"].ToString();
                        CKN.KetNoiKhongDay = reader["KETNOIKHONGDAY"].ToString();
                        CKN.KheDocTheNho = reader["KHEDOCTHENHO"].ToString();
                        CKN.WebCam = reader["WEBCAM"].ToString();
                        CKN.TinhNangKhac = reader["TINHNANGKHAC"].ToString();
                        CKN.DenBanPhim = reader["DENBANPHIM"].ToString();
                    };

                }
            }
            return kh;
        }
        //context sự kiện
        public List<SuKien> laySuKien()
        {
            List<SuKien> list = new List<SuKien>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from sukien";
            return CKN;
        }

        public int TaoCongKetNoi(CongKetNoi ckn)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into CongKetNoi value(?mackn, ?conggiaotiep, ?ketnoikhongday, ?khedocthenho, ?webcam, ?tinhnangkhac, ?denbanphim) ";//ON DUPLICATE KEY UPDATE mackn = ?mackn
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("mackn", ckn.MaCKN.ToString());
                cmd.Parameters.AddWithValue("conggiaotiep", ckn.CongGiaoTiep.ToString());
                cmd.Parameters.AddWithValue("ketnoikhongday", ckn.KetNoiKhongDay.ToString());
                cmd.Parameters.AddWithValue("khedocthenho", ckn.KheDocTheNho.ToString());
                cmd.Parameters.AddWithValue("webcam", ckn.WebCam.ToString());
                cmd.Parameters.AddWithValue("tinhnangkhac", ckn.TinhNangKhac.ToString());
                cmd.Parameters.AddWithValue("denbanphim", ckn.DenBanPhim.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int CapNhatCongKetNoi(CongKetNoi ckn)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string mackn = ckn.MaCKN;
                string query = "update CongKetNoi set conggiaotiep=@conggiaotiep, ketnoikhongday =@ketnoikhongday, khedocthenho=@khedocthenho, webcam =@webcam, tinhnangkhac=@tinhnangkhac, denbanphim=@denbanphim where mackn = @mackn";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mackn", mackn);
                cmd.Parameters.AddWithValue("mackn", ckn.MaCKN.ToString());
                cmd.Parameters.AddWithValue("conggiaotiep", ckn.CongGiaoTiep.ToString());
                cmd.Parameters.AddWithValue("ketnoikhongday", ckn.KetNoiKhongDay.ToString());
                cmd.Parameters.AddWithValue("khedocthenho", ckn.KheDocTheNho.ToString());
                cmd.Parameters.AddWithValue("webcam", ckn.WebCam.ToString());
                cmd.Parameters.AddWithValue("tinhnangkhac", ckn.TinhNangKhac.ToString());
                cmd.Parameters.AddWithValue("denbanphim", ckn.DenBanPhim.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int XoaCongKetNoi(string mackn)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from congketnoi where mackn = @mackn ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mackn", mackn); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        //MAN HINH MODEL ManHinh
        /*create table MANHINH
        (
           MAMH                 char(5) not null,
           KICHTHUOC            varchar(20),
           DOPHANGIAI           varchar(50),
           TANSOQUET            varchar(10),
           CONGNGHEMH           varchar(100),
           CAMUNG               varchar(10),
           primary key (MAMH)
        )DEFAULT CHARSET=utf8mb4;
        */

        public List<ManHinh> LayDSManHinh()
        {
            List<ManHinh> list = new List<ManHinh>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from ManHinh";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SuKien()
                        {
                            MaSK = reader["mask"].ToString(),
                            TenSK = reader["tensk"].ToString(),
                            PhanTramGiamGia = Convert.ToInt32(reader["PHANTRAMGIAMGIA"]),
                            NgayBD = (DateTime)reader["ngaybd"],
                            NgayKT = (DateTime)reader["ngaykt"]
                        list.Add(new ManHinh()
                        {
                            MaMH = reader["MAMH"].ToString(),
                            KichThuoc = reader["KICHTHUOC"].ToString(),
                            DoPhanGiai = reader["DOPHANGIAI"].ToString(),
                            TanSoQuet = reader["TANSOQUET"].ToString(),
                            CongNgheMH = reader["CONGNGHEMH"].ToString(),
                            CamUng = reader["CAMUNG"].ToString(),
                        });

                    }
                }
            }
            return list;
        }
        public int taoSuKien(SuKien sk)

        public ManHinh LayManHinh(string mamh)
        {

            ManHinh MH = new ManHinh();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from ManHinh where mamh =@mamh";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mamh", mamh);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MH.MaMH = reader["MAMH"].ToString();
                        MH.KichThuoc = reader["KICHTHUOC"].ToString();
                        MH.DoPhanGiai = reader["DOPHANGIAI"].ToString();
                        MH.TanSoQuet = reader["TANSOQUET"].ToString();
                        MH.CongNgheMH = reader["CONGNGHEMH"].ToString();
                        MH.CamUng = reader["CAMUNG"].ToString();
                    };

                }
            }
            return MH;
        }

        public int TaoManHinh(ManHinh mh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into sukien value(?mask, ?tensk, ?phanTramGiamGia, ?ngayBD,?ngayKT);";
                //string query = "insert into khachhang value(?tendangnhap, ?tenkh, ?sodt, ?email, ?gioitinh) ";//ON DUPLICATE KEY UPDATE MaKH = ?makh
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //cmd.Parameters.AddWithValue("makh", kh.MaKH.ToString());
                cmd.Parameters.AddWithValue("mask", sk.MaSK.ToString());
                cmd.Parameters.AddWithValue("tensk", sk.TenSK.ToString());
                cmd.Parameters.AddWithValue("phanTramGiamGia", Convert.ToInt32(sk.PhanTramGiamGia));
                cmd.Parameters.AddWithValue("ngayBD", sk.NgayBD);
                cmd.Parameters.AddWithValue("ngayKT", sk.NgayKT);
                string query = "insert into manhinh value(?mamh, ?kichthuoc, ?dophangiai, ?tansoquet, ?congnghemh, ?camung) ";//ON DUPLICATE KEY UPDATE mamh = ?mamh
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("mamh", mh.MaMH.ToString());
                cmd.Parameters.AddWithValue("kichthuoc", mh.KichThuoc.ToString());
                cmd.Parameters.AddWithValue("dophangiai", mh.DoPhanGiai.ToString());
                cmd.Parameters.AddWithValue("tansoquet", mh.TanSoQuet.ToString());
                cmd.Parameters.AddWithValue("congnghemh", mh.CongNgheMH.ToString());
                cmd.Parameters.AddWithValue("camung", mh.CamUng.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int capNhatSuKien(SuKien sk)
        public int CapNhatManHinh(ManHinh mh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"UPDATE sukien
                                    SET
                                    tensk = @tensk,
                                    phantramgiamgia = @phantramgiamgia,
                                    ngaybd = @ngaybd,
                                    ngaykt = @ngaykt,
                                    WHERE mask = @mask;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("tensk", sk.TenSK.ToString());
                cmd.Parameters.AddWithValue("phantramgiamgia", Convert.ToInt32(sk.PhanTramGiamGia));
                cmd.Parameters.AddWithValue("ngaybd", sk.NgayBD);
                cmd.Parameters.AddWithValue("ngaykt", sk.NgayKT);
                cmd.Parameters.AddWithValue("mask", sk.MaSK.ToString());
                string mamh = mh.MaMH;
                string query = "update manhinh set kichthuoc=@kichthuoc, dophangiai =@dophangiai, tansoquet=@tansoquet, congnghemh =@congnghemh, camung=@camung where mamh = @mamh";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mamh", mamh);
                cmd.Parameters.AddWithValue("mamh", mh.MaMH.ToString());
                cmd.Parameters.AddWithValue("kichthuoc", mh.KichThuoc.ToString());
                cmd.Parameters.AddWithValue("dophangiai", mh.DoPhanGiai.ToString());
                cmd.Parameters.AddWithValue("tansoquet", mh.TanSoQuet.ToString());
                cmd.Parameters.AddWithValue("congnghemh", mh.CongNgheMH.ToString());
                cmd.Parameters.AddWithValue("camung", mh.CamUng.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int xoaSuKien(string mask)
        public int XoaManHinh(string mamh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string temp = mask;
                string query = "delete from SuKien where mask = @mask ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mask", temp); //Binding
                string query = "delete from manhinh where mamh = @mamh ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mamh", mamh); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }
        public SuKien laySuKien(string mask)
        {

            SuKien sk = new SuKien();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string temp = mask;
                string query = "select * from SuKien where mask =@mask";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mask", temp);

        //SAN PHAM MODEL SanPham
        /*create table SANPHAM
        (
           MASP                 char(6) not null,
           MANHINH              char(5) not null,
           BOXULY               char(5) not null,
           RAM                  char(5) not null,
           CONGKETNOI           char(5) not null,
           DANHMUC              char(6) not null,
           TENSP                varchar(100),
           SOLUONG              int,
           MAUSAC               varchar(20),
           OCUNG                varchar(200),
           CARDMANHINH          varchar(100),
           DACBIET              varchar(100),
           HDH                  varchar(100),
           THIETKE              varchar(50),
           KHICHTHUOC_TRONGLUONG varchar(100),
           WEBCAM               varchar(50),
           PIN                  varchar(50),
           RAMAT                int,
           MOTA                 varchar(200),
           DONGIA               bigint,
           HINHANH              varchar(200),
           primary key (MASP)
        )DEFAULT CHARSET=utf8mb4;
        */

        public List<SanPham> LayDSSanPham()
        {
            List<SanPham> list = new List<SanPham>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from SanPham";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SanPham()
                        {
                            MaSP = reader["MaSP"].ToString(),
                            ManHinh = reader["ManHinh"].ToString(),
                            BoXuLy = reader["BoXuLy"].ToString(),
                            RAM = reader["RAM"].ToString(),
                            CongKN = reader["CongKetNoi"].ToString(),
                            DanhMuc = reader["DanhMuc"].ToString(),
                            TenSP = reader["TenSP"].ToString(),
                            SoLuong = Convert.ToInt32(reader["SoLuong"]),
                            MauSac = reader["MauSac"].ToString(),
                            OCung = reader["OCung"].ToString(),
                            CardMH = reader["CardManHinh"].ToString(),
                            DacBiet = reader["DacBiet"].ToString(),
                            HDH = reader["HDH"].ToString(),
                            ThietKe = reader["ThietKe"].ToString(),
                            KichThuoc_TrongLuong = reader["KichThuoc_TrongLuong"].ToString(),
                            Webcam = reader["Webcam"].ToString(),
                            Pin = reader["Pin"].ToString(),
                            RaMat = Convert.ToInt32(reader["RaMat"]),
                            MoTa = reader["MoTa"].ToString(),
                            DonGia = Convert.ToInt64(reader["DonGia"]),
                            HinhAnh = reader["HinhAnh"].ToString(),
                        });

                    }
                }
            }
            return list;
        }

        public SanPham LaySanPham(string masp)
        {

            SanPham SP = new SanPham();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "select * from SanPham where masp=@masp";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@masp", masp);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sk.MaSK = reader["mask"].ToString();
                        sk.TenSK = reader["tensk"].ToString();
                        sk.PhanTramGiamGia = Convert.ToInt32(reader["PHANTRAMGIAMGIA"]);
                        sk.NgayBD = (DateTime)reader["ngaybd"];
                        sk.NgayKT = (DateTime)reader["ngaykt"];
                        SP.MaSP = reader["MaSP"].ToString();
                        SP.ManHinh = reader["ManHinh"].ToString();
                        SP.BoXuLy = reader["BoXuLy"].ToString();
                        SP.RAM = reader["RAM"].ToString();
                        SP.CongKN = reader["CongKetNoi"].ToString();
                        SP.DanhMuc = reader["DanhMuc"].ToString();
                        SP.TenSP = reader["TenSP"].ToString();
                        SP.SoLuong = Convert.ToInt32(reader["SoLuong"]);
                        SP.MauSac = reader["MauSac"].ToString();
                        SP.OCung = reader["OCung"].ToString();
                        SP.CardMH = reader["CardManHinh"].ToString();
                        SP.DacBiet = reader["DacBiet"].ToString();
                        SP.HDH = reader["HDH"].ToString();
                        SP.ThietKe = reader["ThietKe"].ToString();
                        SP.KichThuoc_TrongLuong = reader["KichThuoc_TrongLuong"].ToString();
                        SP.Webcam = reader["Webcam"].ToString();
                        SP.Pin = reader["Pin"].ToString();
                        SP.RaMat = Convert.ToInt32(reader["RaMat"]);
                        SP.MoTa = reader["MoTa"].ToString();
                        SP.DonGia = Convert.ToInt64(reader["DonGia"]);
                        SP.HinhAnh = reader["HinhAnh"].ToString();
                    };

                }
            }
            return sk;
            return SP;
        }

        public int TaoSanPham(SanPham sp)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = @"insert into sanpham value(?masp, ?manhinh, ?boxuly, ?RAM, ?congketnoi, ?danhmuc, ?tensp,
                                                           ?soluong, ?mausac, ?ocung, ?cardmanhinh, ?dacbiet, ?hdh, ?thietke,
                                                           ?kichthuoc_trongluong, ?webcam, ?pin, ?ramat,?mota, ?dongia, ?hinhanh) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("masp", sp.MaSP.ToString());
                cmd.Parameters.AddWithValue("manhinh", sp.ManHinh.ToString());
                cmd.Parameters.AddWithValue("boxuly", sp.BoXuLy.ToString());
                cmd.Parameters.AddWithValue("RAM", sp.RAM.ToString());
                cmd.Parameters.AddWithValue("congketnoi", sp.CongKN.ToString());
                cmd.Parameters.AddWithValue("danhmuc", sp.DanhMuc.ToString());
                cmd.Parameters.AddWithValue("tensp", sp.TenSP.ToString());
                cmd.Parameters.AddWithValue("soluong", Convert.ToInt32(sp.SoLuong.ToString()));
                cmd.Parameters.AddWithValue("mausac", sp.MauSac.ToString());
                cmd.Parameters.AddWithValue("ocung", sp.OCung.ToString());
                cmd.Parameters.AddWithValue("cardmanhinh", sp.CardMH.ToString());
                cmd.Parameters.AddWithValue("dacbiet", sp.DacBiet.ToString());
                cmd.Parameters.AddWithValue("hdh", sp.HDH.ToString());
                cmd.Parameters.AddWithValue("thietke", sp.ThietKe.ToString());
                cmd.Parameters.AddWithValue("kichthuoc_trongluong", sp.KichThuoc_TrongLuong.ToString());
                cmd.Parameters.AddWithValue("webcam", sp.Webcam.ToString());
                cmd.Parameters.AddWithValue("pin", sp.Pin.ToString());
                cmd.Parameters.AddWithValue("ramat", Convert.ToInt32(sp.RaMat.ToString()));
                cmd.Parameters.AddWithValue("mota", sp.MoTa.ToString());
                cmd.Parameters.AddWithValue("dongia", Convert.ToInt64(sp.DonGia.ToString()));
                cmd.Parameters.AddWithValue("hinhanh", sp.HinhAnh.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int CapNhatSanPham(SanPham sp)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string masp = sp.MaSP;
                string query = @"update sanpham set masp=@masp, manhinh=@manhinh, boxuly=@boxuly, RAM=@RAM, congketnoi=@congketnoi, danhmuc=@danhmuc, tensp=@tensp,
                                                           soluong=@soluong, mausac=@mausac, ocung=@ocung, cardmanhinh=@cardmanhinh, dacbiet=@dacbiet, hdh=@hdh, thietke=@thietke,
                                                           kichtuoc_trongluong=@kichthuoc_trongluong, webcam=@webcam, pin=@pin, ramat=@ramat,mota=@mota, dongia=@dongia, hinhanh=@hinhanh) ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@masp", masp);
                cmd.Parameters.AddWithValue("masp", sp.MaSP.ToString());
                cmd.Parameters.AddWithValue("manhinh", sp.ManHinh.ToString());
                cmd.Parameters.AddWithValue("boxuly", sp.BoXuLy.ToString());
                cmd.Parameters.AddWithValue("RAM", sp.RAM.ToString());
                cmd.Parameters.AddWithValue("congketnoi", sp.CongKN.ToString());
                cmd.Parameters.AddWithValue("danhmuc", sp.DanhMuc.ToString());
                cmd.Parameters.AddWithValue("tensp", sp.TenSP.ToString());
                cmd.Parameters.AddWithValue("soluong", Convert.ToInt32(sp.SoLuong.ToString()));
                cmd.Parameters.AddWithValue("mausac", sp.MauSac.ToString());
                cmd.Parameters.AddWithValue("ocung", sp.OCung.ToString());
                cmd.Parameters.AddWithValue("cardmanhinh", sp.CardMH.ToString());
                cmd.Parameters.AddWithValue("dacbiet", sp.DacBiet.ToString());
                cmd.Parameters.AddWithValue("hdh", sp.HDH.ToString());
                cmd.Parameters.AddWithValue("thietke", sp.ThietKe.ToString());
                cmd.Parameters.AddWithValue("kichthuoc_trongluong", sp.KichThuoc_TrongLuong.ToString());
                cmd.Parameters.AddWithValue("webcam", sp.Webcam.ToString());
                cmd.Parameters.AddWithValue("pin", sp.Pin.ToString());
                cmd.Parameters.AddWithValue("ramat", Convert.ToInt32(sp.RaMat.ToString()));
                cmd.Parameters.AddWithValue("mota", sp.MoTa.ToString());
                cmd.Parameters.AddWithValue("dongia", Convert.ToInt64(sp.DonGia.ToString()));
                cmd.Parameters.AddWithValue("hinhanh", sp.HinhAnh.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int XoaSanPham(string masp)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from sanpham where masp = @masp ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@masp", masp); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }
    }

}
