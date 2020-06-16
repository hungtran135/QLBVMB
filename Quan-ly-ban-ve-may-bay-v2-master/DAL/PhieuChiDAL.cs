using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class PhieuChiDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public PhieuChiDAL()
        {
            dc = new DataConnection();
        }

        public DataTable GetAndSortDesc()
        {
            SqlConnection con = dc.GetConnect();
            string sqlQuery = "SELECT * FROM PHIEUCHI ORDER BY MAPHIEUCHI DESC";
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private string TaoMaPhieuChi()
        {
            DataTable dt = this.GetAndSortDesc();
            if (dt.Rows.Count == 0)
                return "PC000" + dt.Rows.Count;
            DataRow row = dt.Rows[0];
            string mapc = row[0].ToString().Substring(2);
            int count = int.Parse(mapc) + 1;
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
            return "PC" + strSoKhong + count;

        }


        public bool InsertPhieuChi(DTO.PhieuChi pc)
        {
            string sql = "INSERT INTO PHIEUCHI(MAPHIEUCHI, id_Nhan_Vien,TENPC,SOTIEN,NOIDUNG,THOIGIAN) VALUES(@MAPCHI, @ID,@TEN,@TIEN,@ND,@TIME)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MAPCHI", SqlDbType.VarChar).Value = TaoMaPhieuChi();
                cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = pc.manv;
                cmd.Parameters.Add("@TEN", SqlDbType.NVarChar).Value = pc.tenpc;
                cmd.Parameters.Add("@TIEN", SqlDbType.Decimal).Value = pc.giapc;
                cmd.Parameters.Add("@ND", SqlDbType.NVarChar).Value = pc.noidung;
                cmd.Parameters.Add("@TIME", SqlDbType.DateTime).Value = pc.thoigian;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }


        public DataTable Get_All_PC()
        {

            SqlConnection con = dc.GetConnect();
            DataTable dt = new DataTable();
            string sqlQuery = string.Format("SELECT PC.MAPHIEUCHI[Mã phiếu chi], PC.id_Nhan_Vien[Mã nhân viên],NV.TenNhanVien[Tên nhân viên], PC.TENPC[Lý do chi], PC.NOIDUNG[Nội dung], PC.THOIGIAN[Thời gian] FROM PHIEUCHI PC INNER JOIN NHANVIEN NV ON NV.id_Nhan_Vien = PC.id_Nhan_Vien ");
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            da.Fill(dt);

            return dt;
        }







    }
}
