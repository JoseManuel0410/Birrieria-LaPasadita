using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birrieria_LaPasadita.Clases
{
    internal class clsVentas
    {
        public int ven_id { get; set; }
        public int ord_id { get; set; }
        public int cli_id { get; set; }
        public int usu_id { get; set; }
        public int mdp_id { get; set; }
        public string ven_fecha { get; set; }
        public string ven_detalles { get; set; }
        public bool ven_domicilio { get; set; }
        public int vde_producto { get; set; }
        public string pro_nombre { get; set; }
        public float vde_importe { get; set; }
        public int vde_cantidad { get; set; }
        public float vde_precio { get; set; }
    }
}
