using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
namespace studentaddmissionform
{
    internal class Class1{
        public static SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\git\c-sharp\studentaddmissionform\student.mdf;Integrated Security=True");
    }
}
