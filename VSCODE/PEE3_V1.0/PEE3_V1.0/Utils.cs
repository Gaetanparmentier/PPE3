using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PEE3_V1._0
{
    class Utils
    {
        public static SqlConnection GetDBConnection()
        {
            string datasource = "DESKTOP-FCOGKPQ";

            string database = "PPE3_GSB";

            return DBSQLServerUtils.GetDBConnection(datasource, database);
        }

    }
}
