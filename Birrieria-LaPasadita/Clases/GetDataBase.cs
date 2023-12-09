using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birrieria_LaPasadita.Clases
{
    internal class GetDataBase
    {
        public static List<clsEmpleado> ObtenerEmpleado(string sConexion)
        {
            List<clsEmpleado> lista = new List<clsEmpleado>();

            SqlConnection con = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader i;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT emp_id as codigo, emp_nombre as nombre, emp_apellidop as paterno, emp_apellidom as materno, emp_telefono as telefono, emp_direccion as direccion FROM EMPLEADO";

            con.Open();
            i = cmd.ExecuteReader();

            while (i.Read())
            {
                clsEmpleado empleado = new clsEmpleado()
                {
                    emp_id = Convert.ToInt32(i[0]),
                    emp_nombre = i.GetString(1),
                    emp_apellidop = i.GetString(2),
                    emp_apellidom = i.GetString(3),
                    emp_telefono = i.GetString(4),
                    emp_direccion = i.GetString(5),
                };
                lista.Add(empleado);
            }
            con.Close();
            i.Close();
            return lista;
        }

        public static List<clsCliente> ObtenerCliente(string sConexion)
        {
            List<clsCliente> lista = new List<clsCliente>();

            SqlConnection con = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader i;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT cli_id as codigo, cli_nombre as nombre, cli_apellidop as paterno, cli_apellidom as materno, cli_telefono as telefono, cli_domicilio as direccion FROM CLIENTE";

            con.Open();
            i = cmd.ExecuteReader();

            while (i.Read())
            {
                clsCliente cliente = new clsCliente()
                {
                    cli_id = Convert.ToInt32(i[0]),
                    cli_nombre = i.GetString(1),
                    cli_apellidop = i.GetString(2),
                    cli_apellidom = i.GetString(3),
                    cli_telefono = i.GetString(4),
                    cli_domicilio = i.GetString(5),
                };
                lista.Add(cliente);
            }
            con.Close();
            i.Close();
            return lista;
        }

        public static List<clsVentas> ObtenerVentas(string sConexion)
        {
            List<clsVentas> lista = new List<clsVentas>();

            SqlConnection con = new SqlConnection(sConexion);
            SqlCommand cmd = new SqlCommand("", con);
            SqlDataReader i;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT V.ven_id, O.ord_id, C.cli_id, U.usu_id, M.mdp_id, V.ven_fecha, V.ven_detalles, V.ven_domicilio, VD.vde_producto, P.pro_nombre AS 'Nombre del Producto', VD.vde_importe, VD.vde_cantidad, VD.vde_precio FROM VENTA V INNER JOIN ORDEN O ON V.ven_orden = O.ord_id INNER JOIN CLIENTE C ON V.ven_cliente = C.cli_id INNER JOIN USUARIO U ON V.ven_usuario = U.usu_id INNER JOIN METODO_DE_PAGO M ON V.ven_mdp = M.mdp_id INNER JOIN VENTA_DETALLE VD ON V.ven_id = VD.vde_venta INNER JOIN PRODUCTO P ON VD.vde_producto = P.pro_id";
            con.Open();
            i = cmd.ExecuteReader();

            while (i.Read())
            {
                clsVentas Venta = new clsVentas()
                {
                    ven_id = Convert.ToInt32(i[0]),
                    ord_id = Convert.ToInt32(i[1]),
                    cli_id = Convert.ToInt32(i[2]),
                    usu_id = Convert.ToInt32(i[3]),
                    mdp_id = Convert.ToInt32(i[4]),
                    ven_fecha = Convert.ToString(i[5]),
                    ven_detalles = i.GetString(6),
                    ven_domicilio = i.GetBoolean(7),
                    vde_producto = Convert.ToInt32(i[8]),
                    pro_nombre = i.GetString(9),
                    vde_importe = i.GetFloat(10),
                    vde_cantidad = Convert.ToInt32(i[11]),
                    vde_precio = i.GetFloat (12),
                };
                lista.Add(Venta);
            }
            con.Close();
            i.Close();
            return lista;
        }
    }
}
