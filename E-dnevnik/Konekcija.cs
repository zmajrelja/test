using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace E_dnevnik
{
    class Konekcija
    {

        static public SqlConnection cs()
        {

            string cs = "Data Source = DESKTOP-9OEBP15\\SQLEXPRESS; Initial Catalog = ednevnik; Integrated Security=true;";

            return new SqlConnection(cs);


        }

    }
}
