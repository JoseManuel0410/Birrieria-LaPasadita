﻿using Birrieria_LaPasadita.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Birrieria_LaPasadita.Pages
{
    /// <summary>
    /// Lógica de interacción para pgnModificar_Clientes.xaml
    /// </summary>
    public partial class pgnModificar_Clientes : Page
    {
        public pgnModificar_Clientes()
        {
            InitializeComponent();
        }

        private void btnModCliente_Click(object sender, RoutedEventArgs e)
        {
            if (txtID.Text == "" || txtNombre.Text == "" || txtApellidoPat.Text == "" || txtApellidoMat.Text == "" || txtApellidoMat.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "")
            {
                MessageBox.Show("Para poder modificar este cliente debes ingresar todos los datos", "Modificar", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                SqlConnection con = new SqlConnection(clsconexion.Conectar());
                SqlCommand cmd = new SqlCommand("", con);

                con.Open();
                cmd.CommandText = "UPDATE CLIENTE SET cli_nombre = '" + txtNombre.Text + "', cli_apellidop = '" + txtApellidoPat.Text + "', cli_apellidom = '" + txtApellidoMat.Text + "', cli_telefono = '" + txtTelefono.Text + "', cli_domicilio = '" + txtDireccion.Text + "' WHERE cli_id = " + txtID.Text + "";
                cmd.ExecuteNonQuery();

                con.Close();
                txtID.Clear();
                txtNombre.Clear();
                txtApellidoPat.Clear();
                txtApellidoMat.Clear();
                txtTelefono.Clear();
                txtDireccion.Clear();
                MessageBox.Show("Cliente modificado");
            }
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            grid2.Visibility = Visibility.Collapsed;
            Maint.Content = new pgnClientes();
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            int clienteID;
            if (!int.TryParse(txtID.Text, out clienteID))
            {
                MessageBox.Show("Por favor, ingrese un ID válido.");
                return;
            }
            else
            {
                SqlConnection con = new SqlConnection(clsconexion.Conectar());
                SqlCommand cmd = new SqlCommand("", con);

                con.Open();
                cmd.CommandText = "SELECT cli_nombre, cli_apellidop, cli_apellidom, cli_telefono, cli_domicilio FROM CLIENTE WHERE cli_id = " + txtID.Text + "";
                cmd.ExecuteNonQuery();

                cmd.Parameters.AddWithValue("", clienteID);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        txtNombre.Text = reader["cli_nombre"].ToString();
                        txtTelefono.Text = reader["cli_telefono"].ToString();
                        txtApellidoPat.Text = reader["cli_apellidop"].ToString();
                        txtApellidoMat.Text = reader["cli_apellidom"].ToString();
                        txtDireccion.Text = reader["cli_domicilio"].ToString();
                    }


                    con.Close();
                }
            }
<<<<<<< HEAD

=======
>>>>>>> f30d370997bda1114b9087d676a7fdae46475452
        }
    }
}
