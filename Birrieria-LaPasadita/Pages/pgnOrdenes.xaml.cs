using System;
using System.Collections.Generic;
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
using System.Collections.ObjectModel;
using Birrieria_LaPasadita.Formularios;
using Birrieria_LaPasadita.Clases;
using System.Data.SqlClient;
using System.Data;
using static Birrieria_LaPasadita.Pages.pgnOrdenes;
using System.Collections;

namespace Birrieria_LaPasadita.Pages
{
    /// <summary>
    /// Lógica de interacción para pgnOrdenes.xaml
    /// </summary>
    public partial class pgnOrdenes : Page
    {

        public pgnOrdenes()
        {
            InitializeComponent();
           
    }
        private void rdbDomicilio_Checked(object sender, RoutedEventArgs e)
        {
            cmbInfoDomicilio.Visibility = Visibility.Visible;
        }

        private void rdbLocal_Checked(object sender, RoutedEventArgs e)
        {
            txtDomicilio.Text = "";
            cbxNumCliente.Text = "";
            cmbInfoDomicilio.Visibility = Visibility.Collapsed;
        }

        public int ID;
        
        private void btnextra_Click(object sender, RoutedEventArgs e)
        {

        }


        private ObservableCollection<clsProducto> productList = new ObservableCollection<clsProducto>();

        private void btnagregar_Click(object sender, RoutedEventArgs e)
        {
            string con = clsconexion.Conectar();
            clsProducto producto = new clsProducto();

            int cantidad;
            if (!int.TryParse(txtcantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad no es un número válido.");
                return;
            }

            List<clsProducto> nuevosProductos = producto.ObtenerProducto(con, ID);

            foreach (var nuevoProducto in nuevosProductos)
            {
                if (!productList.Any(p => p.pro_id == nuevoProducto.pro_id))
                {
                    nuevoProducto.tempO_cantidad = cantidad;
                    nuevoProducto.tempO_subtotal = cantidad * nuevoProducto.pro_precio;

                    productList.Add(nuevoProducto);
                }
            }
            decimal total = productList.Sum(p => p.tempO_subtotal);
            txtTotal.Text = total.ToString();
            lstproductos.ItemsSource = productList;

        }

        private void InsertarOrden(string con)
        {
            foreach (var producto in productList)
            {
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO ORDEN_DETALLE (ode_producto, ode_importe, ode_cantidad, ode_subtotal) " +
                        "VALUES (@ode_producto, @ode_importe, @ode_cantidad, @ode_subtotal)", connection))
                    {
                        cmd.Parameters.AddWithValue("@ode_producto", producto.pro_id);
                        cmd.Parameters.AddWithValue("@ode_importe", producto.tempO_subtotal);
                        cmd.Parameters.AddWithValue("@ode_cantidad", producto.tempO_cantidad);
                        cmd.Parameters.AddWithValue("@ode_subtotal", producto.tempO_subtotal);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void btntaco_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 1;
            txtelemento.Text = "Tacos:";
            
        }

        private void btnmedia_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 2;
            txtelemento.Text = "Medias:";
        }

        private void btnorden_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 3;
            txtelemento.Text = "Orden:";
        }

        private void btnquesabirria_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 4;
            txtelemento.Text = "Quesabirrias:";
        }

        private void btnrefrescos_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 5;
            txtelemento.Text = "Refrescos:";
        }

        private void btnaguas_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 6;
            txtelemento.Text = "Aguas:";
        }

        private void btnaguas1L_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 7;
            txtelemento.Text = "Aguas1L:";
        }

        private void btncafes_Click_1(object sender, RoutedEventArgs e)
        {
            ID = 8;
            txtelemento.Text = "Cafes:";
        }

        private void btnregistar_Click(object sender, RoutedEventArgs e)
        {
            InsertarOrden(clsconexion.Conectar());
            productList.Clear();
            lstproductos.ItemsSource = null;
            txtTotal.Text = string.Empty;
        }
    }
}
