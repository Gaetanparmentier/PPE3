using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PEE3_V1._0
{
    class DBSQLServerUtils
    {
        SqlConnection connection = new SqlConnection();
        public static SqlConnection GetDBConnection(string datasource, string database)
        {
            //
            // Data Source=TRAN-VMWARE\SQLEXPRESS;Initial Catalog=simplehr;Persist Security Info=True;User ID=sa;Password=12345
            //
            string connString = "Data Source="+ datasource+";Initial Catalog="+database+";Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            return conn;
        }
    }
}
