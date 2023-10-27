using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birrieria_LaPasadita.Clases
{
    public class clsconexion
    {
        public static string Conectar()
        {
            string con = @"DATA SOURCE=COMPUA\SQLEXPRESS; INITIAL CATALOG=BIRRIERIA; INTEGRATED SECURITY=TRUE";
            return con;
        }
    }
}
