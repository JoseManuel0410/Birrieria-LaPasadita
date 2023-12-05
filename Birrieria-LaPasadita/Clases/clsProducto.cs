using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Birrieria_LaPasadita.Clases
{
    internal class clsProducto
    {
        public clsProducto() { }
        public clsProducto(int pro_id)
        {
            this.pro_id = pro_id;
        }

        public int pro_id { get; set; }
        public string pro_nombre { get; set; }
        public decimal pro_precio { get; set; }
        public int tempO_cantidad { get; set; }
        public decimal tempO_subtotal { get; set; }
        public decimal tempO_total { get; set; }



        public List<clsProducto> ObtenerProducto(string sConexion, int pro_id)
        {
            List<clsProducto> lista = new List<clsProducto>();

            using (SqlConnection con = new SqlConnection(sConexion))
            {
                con.Open();

                using (SqlCommand cmd = new SqlCommand("select pro_id,pro_nombre,pro_precio from PRODUCTO where pro_id = @pro_id", con))
                {
                    cmd.Parameters.AddWithValue("@pro_id", pro_id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clsProducto Producto = new clsProducto()
                            {
                                pro_id = Convert.ToInt32(reader["pro_id"]),
                                pro_nombre = reader.GetString(reader.GetOrdinal("pro_nombre")),
                                pro_precio = Convert.ToDecimal(reader["pro_precio"]),
                            };
                            lista.Add(Producto);
                        }
                    }
                }
            }

            return lista;
        }
    }

}
