using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace QLBVMB.DAL
{
    class NhanvienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;


        static readonly string PasswordHash = "P@@Sw0rd";
        static readonly string SaltKey = "S@LT&KEY";
        static readonly string VIKey = "@1B2c3D4e5F6g7H8";


        public NhanvienDAL()
        {
            dc = new DataConnection();
        }



        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT * FROM NHANVIEN ORDER BY id_Nhan_Vien DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaNhanVien()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "NV000" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string maTuyenBay = row[0].ToString().Substring(2);
            int count = int.Parse(maTuyenBay) + 1;
            int temp = count;
            string strSoKhong = "";
            int dem = 0;
            while (temp > 0)
            {
                temp /= 10;
                dem++;
            }
            for (int i = 0; i < 4 - dem; i++)
            {
                strSoKhong += "0";
            }
            return "NV" + strSoKhong + count;

        }




        public bool Login(string user,string pass)
        {
            //string sql = "SELECT * FROM NHANVIEN WHERE UserName = @user and PassWord = @pass";
            //string sql = " SELECT * FROM NHANVIEN";

            //SqlConnection con = dc.GetConnect();
            //try
            //{
            //    cmd = new SqlCommand(sql, con);
            //    con.Open();
            //    cmd.Parameters.Add("@user", SqlDbType.NChar).Value = user;
            //    cmd.Parameters.Add("@pass", SqlDbType.NChar).Value = pass;
            //    cmd.ExecuteNonQuery();
            //    con.Close();
            //}
            //catch (Exception e)
            //{
            //    return false;
            //}
            //return true;


            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM NHANVIEN WHERE UserName = '{0}' and PassWord = '{1}'",user,pass);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            if(dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            



        }



        public string Get_maNV(string user, string pass)
        {
     
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM NHANVIEN WHERE UserName = '{0}' and PassWord = '{1}'", user, pass);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0][0].ToString();
            }
            else return "Lỗi";
          
        }




        public string Get_tenNV(string id)
        {

            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM NHANVIEN WHERE id_Nhan_Vien = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0][1].ToString();
            }
            else return "Lỗi";

        }

        public bool check_trung_username(DTO.Nhanvien nv)
        {
           
            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("select * from NHANVIEN where id_Nhan_Vien!= '{0}' and UserName='{1}'", nv.manv,nv.username);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            else return true;
        }

        public bool check_trung_username_insert(DTO.Nhanvien nv)
        {

            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("select * from NHANVIEN where UserName='{0}'", nv.username);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            else return true;
        }


        public bool check_passlv2(string user, string pass2)
        {

            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("select * from NHANVIEN where UserName='{0}' and PassWord2='{1}'", user,pass2);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return false;
            }
            else return true;

        }



        public DataTable Get_All(string id)
        {

            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT * FROM NHANVIEN WHERE id_Nhan_Vien = '{0}'", id);
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);

            return dt;
        }


        public DataTable Get_All_NV()
        {

            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT id_Nhan_Vien[Mã nhân viên], TenNhanVien[Tên nhân viên], DiaChi[Địa chỉ], SoDienThoai[Số điện thoại], Email[Email], CMND[CMND], UserName[Tài khoản], Password[Mật khẩu], LOAI[Chức vụ], PassWord2[Mật khẩu cấp 2] FROM NHANVIEN");
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);

            return dt;
        }


        public bool InsertNhanVien(DTO.Nhanvien nv)
        {
            string sql = "INSERT INTO NHANVIEN(id_Nhan_Vien, TenNhanVien, DiaChi, SoDienThoai, Email, CMND, UserName, PassWord, LOAI, PassWord2 ) VALUES(@MANV, @TENNV,@DIACHI,@SDT,@EMAIL,@CMND,@USER,@PASS,@LOAI,@PASS2)";
            SqlConnection con = dc.GetConnect();
            try
            {

                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = TaoMaNhanVien();
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.tennv;
                cmd.Parameters.Add("@DIACHI", SqlDbType.NVarChar).Value = nv.diachi;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = nv.sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NChar).Value = nv.email;
                cmd.Parameters.Add("@CMND", SqlDbType.NChar).Value = nv.cmnd;
                cmd.Parameters.Add("@USER", SqlDbType.NChar).Value = nv.username;
                cmd.Parameters.Add("@PASS", SqlDbType.NChar).Value = nv.password;
                cmd.Parameters.Add("@LOAI", SqlDbType.NVarChar).Value = nv.loai;
                cmd.Parameters.Add("@PASS2", SqlDbType.NChar).Value = nv.passwordlv2;


                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public bool UpdateNhanVien(DTO.Nhanvien nv)
        {
           


            //UPDATE NHANVIEN SET TenNhanVien = 'SIU', DiaChi = 't', SoDienThoai = 't', Email = 't', CMND = 't', LOAI = 'Nhân viên', UserName = 'admin2', PassWord = '123', PassWord2 = '123456' WHERE id_Nhan_Vien = 'NV0002'

            string sql = "UPDATE NHANVIEN SET TenNhanVien = @TENNV, DiaChi =@DC, SoDienThoai =@SDT, Email = @EMAIL, CMND = @CMND, LOAI = @L, UserName = @U, PassWord = @P, PassWord2 = @P2 WHERE id_Nhan_Vien =@ID";
            //string sql = "UPDATE NHANVIEN SET TenNhanVien=@TENNV, DiaChi=@DC, SoDienThoai=@SDT, Email=@EMAIL, CMND=@CMND, LOAI=@L, UserName=@U, PassWord=@P, PassWord2=@P2 WHERE id_Nhan_Vien=@ID";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENNV", SqlDbType.NVarChar).Value = nv.tennv;

                cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = nv.diachi;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = nv.sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NChar).Value = nv.email;
                cmd.Parameters.Add("@CMND", SqlDbType.NChar).Value = nv.cmnd;
                cmd.Parameters.Add("@L", SqlDbType.NChar).Value = nv.loai;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = nv.manv;

                cmd.Parameters.Add("@U", SqlDbType.NChar).Value = nv.username;
                cmd.Parameters.Add("@P", SqlDbType.NChar).Value = nv.password;
                cmd.Parameters.Add("@P2", SqlDbType.NChar).Value = nv.passwordlv2;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public bool DeleteNhanVien(DTO.Nhanvien nv)
        {
            string sql = "DELETE NHANVIEN WHERE id_Nhan_Vien = @MANV";

            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nv.manv;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public bool UpdateNV(string id, string ten,  string diachi, string sdt, string email, string cmnd, string chucvu)
        {

            string sql = "UPDATE NHANVIEN SET TenNhanVien=@TENNV, DiaChi=@DC, SoDienThoai=@SDT, Email=@EMAIL, CMND=@CMND, LOAI=@L WHERE id_Nhan_Vien=@ID";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@TENNV", SqlDbType.NChar).Value = ten;
              
                cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = diachi;
                cmd.Parameters.Add("@SDT", SqlDbType.NChar).Value = sdt;
                cmd.Parameters.Add("@EMAIL", SqlDbType.NChar).Value = email;
                cmd.Parameters.Add("@CMND", SqlDbType.NChar).Value = cmnd;
                cmd.Parameters.Add("@L", SqlDbType.NChar).Value = chucvu;
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;


        }



        public bool Update_Doi_Pass(string pass, string id)
        {
            
            string sql = "UPDATE NHANVIEN SET PassWord=@NEWPASS WHERE id_Nhan_Vien=@ID";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
         
                cmd.Parameters.Add("@NEWPASS", SqlDbType.NChar).Value = pass;
          
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = id;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }



        public bool Quen_Pass(string pass, string name)
        {

            string sql = "UPDATE NHANVIEN SET PassWord=@NEWPASS WHERE UserName=@NAME";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();

                cmd.Parameters.Add("@NEWPASS", SqlDbType.NVarChar).Value = pass;

                cmd.Parameters.Add("@NAME", SqlDbType.NVarChar).Value = name;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;

        }

        public string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.Zeros };
            var encryptor = symmetricKey.CreateEncryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));

            byte[] cipherTextBytes;

            using (var memoryStream = new System.IO.MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                    cryptoStream.FlushFinalBlock();
                    cipherTextBytes = memoryStream.ToArray();
                    cryptoStream.Close();
                }
                memoryStream.Close();
            }
            return Convert.ToBase64String(cipherTextBytes);
        }


        public string Decrypt(string encryptedText)
        {
            byte[] cipherTextBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = new Rfc2898DeriveBytes(PasswordHash, Encoding.ASCII.GetBytes(SaltKey)).GetBytes(256 / 8);
            var symmetricKey = new RijndaelManaged() { Mode = CipherMode.CBC, Padding = PaddingMode.None };

            var decryptor = symmetricKey.CreateDecryptor(keyBytes, Encoding.ASCII.GetBytes(VIKey));
            var memoryStream = new MemoryStream(cipherTextBytes);
            var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
            byte[] plainTextBytes = new byte[cipherTextBytes.Length];

            int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
            memoryStream.Close();
            cryptoStream.Close();
            return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount).TrimEnd("\0".ToCharArray());
        }






















    }
}
