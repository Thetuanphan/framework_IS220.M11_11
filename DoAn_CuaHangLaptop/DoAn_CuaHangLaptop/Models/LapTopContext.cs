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
                string query = "insert into DanhMucSanPham values(?madm, ?tendm) ";//ON DUPLICATE KEY UPDATE madm = ?madm
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("madm", "");
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
                cmd.Parameters.AddWithValue("@madm", madm); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        // BO NHO RAM MODEL
        public List<BoNhoRAM> LayDSBoNhoRAM()
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
                            MaRAM = reader["MARAM"]?.ToString(),
                            DungLuongRAM = reader["DUNGLUONGRAM"]?.ToString(),
                            LoaiRAM = reader["loairam"]?.ToString(),
                            BusRAM = reader["BUSRAM"]?.ToString(),
                            HoTroToiDa = reader["HOTROTOIDA"]?.ToString(),
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
                cmd.Parameters.AddWithValue("@maram", maram);
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        BNR.MaRAM = reader["MARAM"].ToString();
                        BNR.DungLuongRAM = reader["DUNGLUONGRAM"]?.ToString();
                        BNR.LoaiRAM = reader["LOAIRAM"]?.ToString();
                        BNR.BusRAM = reader["BUSRAM"]?.ToString();
                        BNR.HoTroToiDa = reader["HOTROTOIDA"]?.ToString();

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
                cmd.Parameters.AddWithValue("maram", "");
                cmd.Parameters.AddWithValue("dungluongram", bnr.DungLuongRAM?.ToString());
                cmd.Parameters.AddWithValue("loairam", bnr.LoaiRAM?.ToString());
                cmd.Parameters.AddWithValue("busram", bnr.BusRAM?.ToString());
                cmd.Parameters.AddWithValue("hotrotoida", bnr.HoTroToiDa?.ToString());
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
                cmd.Parameters.AddWithValue("dungluongram", bnr.DungLuongRAM?.ToString());
                cmd.Parameters.AddWithValue("loairam", bnr.LoaiRAM?.ToString());
                cmd.Parameters.AddWithValue("busram", bnr.BusRAM?.ToString());
                cmd.Parameters.AddWithValue("hotrotoida", bnr.HoTroToiDa?.ToString());
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
                            CongNgheCPU = reader["CONGNGHECPU"]?.ToString(),
                            SoNhan = Convert.ToInt32(reader["SONHAN"]),
                            SoLuong = Convert.ToInt32(reader["SOLUONG"]),
                            TocDoCPU = reader["TocDoCPU"]?.ToString(),
                            TocDoToiDa = reader["TocDoToiDa"]?.ToString(),
                            BoNhoDem = reader["BoNhoDem"]?.ToString(),
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
                        BXL.CongNgheCPU = reader["CONGNGHECPU"]?.ToString();
                        BXL.SoNhan = Convert.ToInt32(reader["SONHAN"]);
                        BXL.SoLuong = Convert.ToInt32(reader["SOLUONG"]);
                        BXL.TocDoCPU = reader["TocDoCPU"]?.ToString();
                        BXL.TocDoToiDa = reader["TocDoToiDa"]?.ToString();
                        BXL.BoNhoDem = reader["BoNhoDem"]?.ToString();
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
                cmd.Parameters.AddWithValue("mabxl", "");
                cmd.Parameters.AddWithValue("congnghecpu", bxl.CongNgheCPU?.ToString());
                cmd.Parameters.AddWithValue("sonhan", Convert.ToInt32(bxl.SoNhan));
                cmd.Parameters.AddWithValue("soluong", Convert.ToInt32(bxl.SoLuong));
                cmd.Parameters.AddWithValue("tocdocpu", bxl.TocDoCPU?.ToString());
                cmd.Parameters.AddWithValue("tocdotoida", bxl.TocDoToiDa?.ToString());
                cmd.Parameters.AddWithValue("bonhodem", bxl.BoNhoDem?.ToString());
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
                conn.Open();
                string mabxl = bxl.MaBXL;
                string query = "update BoXuLy set congnghecpu=@congnghecpu, sonhan =@sonhan, soluong=@soluong, tocdocpu =@tocdocpu, tocdotoida=@tocdotoida, bonhodem=@bonhodem where mabxl = @mabxl";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mabxl", mabxl);
                cmd.Parameters.AddWithValue("congnghecpu", bxl.CongNgheCPU?.ToString());
                cmd.Parameters.AddWithValue("sonhan", Convert.ToInt32(bxl.SoNhan));
                cmd.Parameters.AddWithValue("soluong", Convert.ToInt32(bxl.SoLuong));
                cmd.Parameters.AddWithValue("tocdocpu", bxl.TocDoCPU?.ToString());
                cmd.Parameters.AddWithValue("tocdotoida", bxl.TocDoToiDa?.ToString());
                cmd.Parameters.AddWithValue("bonhodem", bxl.BoNhoDem?.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

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
                        list.Add(new CongKetNoi()
                        {
                            MaCKN = reader["MACKN"].ToString(),
                            CongGiaoTiep = reader["CONGGIAOTIEP"]?.ToString(),
                            KetNoiKhongDay = reader["KETNOIKHONGDAY"]?.ToString(),
                            KheDocTheNho = reader["KHEDOCTHENHO"]?.ToString(),
                            WebCam = reader["WEBCAM"]?.ToString(),
                            TinhNangKhac = reader["TINHNANGKHAC"]?.ToString(),
                            DenBanPhim = reader["DENBANPHIM"]?.ToString(),
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
                        CKN.CongGiaoTiep = reader["CONGGIAOTIEP"]?.ToString();
                        CKN.KetNoiKhongDay = reader["KETNOIKHONGDAY"]?.ToString();
                        CKN.KheDocTheNho = reader["KHEDOCTHENHO"]?.ToString();
                        CKN.WebCam = reader["WEBCAM"]?.ToString();
                        CKN.TinhNangKhac = reader["TINHNANGKHAC"]?.ToString();
                        CKN.DenBanPhim = reader["DENBANPHIM"]?.ToString();
                    };

                }
            }
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
                cmd.Parameters.AddWithValue("mackn", "");
                cmd.Parameters.AddWithValue("conggiaotiep", ckn.CongGiaoTiep?.ToString());
                cmd.Parameters.AddWithValue("ketnoikhongday", ckn.KetNoiKhongDay?.ToString());

                cmd.Parameters.AddWithValue("khedocthenho", ckn.KheDocTheNho?.ToString());

                cmd.Parameters.AddWithValue("webcam", ckn.WebCam?.ToString());

                cmd.Parameters.AddWithValue("tinhnangkhac", ckn.TinhNangKhac?.ToString());

                cmd.Parameters.AddWithValue("denbanphim", ckn.DenBanPhim?.ToString());
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
                cmd.Parameters.AddWithValue("conggiaotiep", ckn.CongGiaoTiep?.ToString());
                cmd.Parameters.AddWithValue("ketnoikhongday", ckn.KetNoiKhongDay?.ToString());
                cmd.Parameters.AddWithValue("khedocthenho", ckn.KheDocTheNho?.ToString());
                cmd.Parameters.AddWithValue("webcam", ckn.WebCam?.ToString());
                cmd.Parameters.AddWithValue("tinhnangkhac", ckn.TinhNangKhac?.ToString());
                cmd.Parameters.AddWithValue("denbanphim", ckn.DenBanPhim?.ToString());
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
                        list.Add(new ManHinh()
                        {
                            MaMH = reader["MAMH"].ToString(),
                            KichThuoc = reader["KICHTHUOC"].ToString(),
                            DoPhanGiai = reader["DOPHANGIAI"]?.ToString(),
                            TanSoQuet = reader["TANSOQUET"]?.ToString(),
                            CongNgheMH = reader["CONGNGHEMH"]?.ToString(),
                            CamUng = reader["CAMUNG"]?.ToString(),
                        });

                    }
                }
            }
            return list;
        }

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
                        MH.DoPhanGiai = reader["DOPHANGIAI"]?.ToString();
                        MH.TanSoQuet = reader["TANSOQUET"]?.ToString();
                        MH.CongNgheMH = reader["CONGNGHEMH"]?.ToString();
                        MH.CamUng = reader["CAMUNG"]?.ToString();
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
                string query = "insert into manhinh value(?mamh, ?kichthuoc, ?dophangiai, ?tansoquet, ?congnghemh, ?camung) ";//ON DUPLICATE KEY UPDATE mamh = ?mamh
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("mamh", "");
                cmd.Parameters.AddWithValue("kichthuoc", mh.KichThuoc.ToString());
                cmd.Parameters.AddWithValue("dophangiai", mh.DoPhanGiai?.ToString());
                cmd.Parameters.AddWithValue("tansoquet", mh.TanSoQuet?.ToString());
                cmd.Parameters.AddWithValue("congnghemh", mh.CongNgheMH?.ToString());
                cmd.Parameters.AddWithValue("camung", mh.CamUng?.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int CapNhatManHinh(ManHinh mh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string mamh = mh.MaMH;
                string query = "update manhinh set kichthuoc=@kichthuoc, dophangiai =@dophangiai, tansoquet=@tansoquet, congnghemh =@congnghemh, camung=@camung where mamh = @mamh";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mamh", mamh);
                cmd.Parameters.AddWithValue("kichthuoc", mh.KichThuoc.ToString());
                cmd.Parameters.AddWithValue("dophangiai", mh.DoPhanGiai?.ToString());
                cmd.Parameters.AddWithValue("tansoquet", mh.TanSoQuet?.ToString());
                cmd.Parameters.AddWithValue("congnghemh", mh.CongNgheMH?.ToString());
                cmd.Parameters.AddWithValue("camung", mh.CamUng?.ToString());
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int XoaManHinh(string mamh)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "delete from manhinh where mamh = @mamh ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mamh", mamh); //Binding
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        //SAN PHAM MODEL SanPham

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
                            DacBiet = reader["DacBiet"]?.ToString(),
                            HDH = reader["HDH"].ToString(),
                            ThietKe = reader["ThietKe"].ToString(),
                            KichThuoc_TrongLuong = reader["KichThuoc_TrongLuong"].ToString(),
                            Webcam = reader["Webcam"]?.ToString(),
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
                        SP.DacBiet = reader["DacBiet"]?.ToString();
                        SP.HDH = reader["HDH"].ToString();
                        SP.ThietKe = reader["ThietKe"].ToString();
                        SP.KichThuoc_TrongLuong = reader["KichThuoc_TrongLuong"].ToString();
                        SP.Webcam = reader["Webcam"]?.ToString();
                        SP.Pin = reader["Pin"].ToString();
                        SP.RaMat = Convert.ToInt32(reader["RaMat"]);
                        SP.MoTa = reader["MoTa"].ToString();
                        SP.DonGia = Convert.ToInt64(reader["DonGia"]);
                        SP.HinhAnh = reader["HinhAnh"].ToString();
                    };

                }
            }
            return SP;
        }

        public int TaoSanPham(SanPham sp)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "insert into SANPHAM value (?masp, ?manhinh, ?boxuly, ?RAM, ?congketnoi, ?danhmuc, ?tensp, ?soluong, ?mausac, ?ocung, ?cardmanhinh, ?dacbiet, ?hdh, ?thietke,?kichthuoc_trongluong, ?webcam, ?pin, ?ramat,?mota, ?dongia, ?hinhanh) ";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("masp", "");
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
                cmd.Parameters.AddWithValue("dacbiet", sp.DacBiet?.ToString());
                cmd.Parameters.AddWithValue("hdh", sp.HDH.ToString());
                cmd.Parameters.AddWithValue("thietke", sp.ThietKe.ToString());
                cmd.Parameters.AddWithValue("kichthuoc_trongluong", sp.KichThuoc_TrongLuong.ToString());
                cmd.Parameters.AddWithValue("webcam", sp.Webcam?.ToString());
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
                cmd.Parameters.AddWithValue("dacbiet", sp.DacBiet?.ToString());
                cmd.Parameters.AddWithValue("hdh", sp.HDH.ToString());
                cmd.Parameters.AddWithValue("thietke", sp.ThietKe.ToString());
                cmd.Parameters.AddWithValue("kichthuoc_trongluong", sp.KichThuoc_TrongLuong.ToString());
                cmd.Parameters.AddWithValue("webcam", sp.Webcam?.ToString());
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
