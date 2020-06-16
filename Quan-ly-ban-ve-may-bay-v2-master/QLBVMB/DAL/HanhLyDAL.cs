using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB.DAL
{
    class HanhLyDAL
    {


        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public HanhLyDAL()
        {
            dc = new DataConnection();
        }


        public DataTable getAllHangve()
        {
            //B1: Tạo câu lệnh Sql để lấy toàn bộ sân bay
            string sql = "SELECT * FROM HANGVE ";
            //B2: Tạo một kết nối đến Sql
            SqlConnection con = dc.GetConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: Mở kết nối
            con.Open();
            //B5: Đổ dữ liệu từ SqlDataAdapter vào DataTable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }























    }
}
