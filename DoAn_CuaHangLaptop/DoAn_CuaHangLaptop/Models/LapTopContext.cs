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
                        });

                    }
                }
            }
            return list;
        }
        public int taoSuKien(SuKien sk)
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
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int capNhatSuKien(SuKien sk)
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
                cmd.ExecuteNonQuery();
                count++;
            }
            return count;
        }

        public int xoaSuKien(string mask)
        {
            int count = 0;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                string temp = mask;
                string query = "delete from SuKien where mask = @mask ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@mask", temp); //Binding
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
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        sk.MaSK = reader["mask"].ToString();
                        sk.TenSK = reader["tensk"].ToString();
                        sk.PhanTramGiamGia = Convert.ToInt32(reader["PHANTRAMGIAMGIA"]);
                        sk.NgayBD = (DateTime)reader["ngaybd"];
                        sk.NgayKT = (DateTime)reader["ngaykt"];
                    };

                }
            }
            return sk;
        }
    }
}
