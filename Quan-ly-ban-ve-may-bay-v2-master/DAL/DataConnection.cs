using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBVMB
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
           // conStr = @"Data Source =.\SQLEXPRESS; Initial Catalog=SELL_PLANE_TICKET_DATABASE; Integrated Security=True";
           conStr = @"Data Source=DESKTOP-EURJ2PN\SQLEXPRESS;Initial Catalog=SELL_PLANE_TICKET_DATABASE;Integrated Security=True";
        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(conStr);
        }
         
    }
}
