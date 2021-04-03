using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp7
{
    class Dataconection
    {
        string Constr;
        public Dataconection()
        {
            //Constr = "Data Source = DESKTOP-B2J7U3P\\SQLEXPRESS;Initial Catalog=QLCuaHang";
            Constr = "Data Source=DESKTOP-B2J7U3P\\SQLEXPRESS;Initial Catalog=QLCuaHang;Integrated Security=True";

        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(Constr);
        }
    }
}
