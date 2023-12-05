﻿using System;
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


    }
}
