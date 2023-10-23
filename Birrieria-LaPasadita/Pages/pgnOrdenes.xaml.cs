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

namespace Birrieria_LaPasadita.Pages
{
    /// <summary>
    /// Lógica de interacción para pgnOrdenes.xaml
    /// </summary>
    public partial class pgnOrdenes : Page
    {
        public pgnOrdenes()
        {
            ObservableCollection<Producto> Items1 = new ObservableCollection<Producto>();
            InitializeComponent();

            Items1.Add(new Producto { ID = 1, Productos = "Producto 1", Precio_unitario = 10.0m, Cantidad = 2, Subtotal = 20.0m });
            Items1.Add(new Producto { ID = 2, Productos = "Producto 2", Precio_unitario = 15.0m, Cantidad = 3, Subtotal = 45.0m });
            Items1.Add(new Producto { ID = 3, Productos = "Producto 3", Precio_unitario = 8.0m, Cantidad = 5, Subtotal = 40.0m });
            Items1.Add(new Producto { ID = 1, Productos = "Producto 1", Precio_unitario = 10.0m, Cantidad = 2, Subtotal = 20.0m });
            Items1.Add(new Producto { ID = 2, Productos = "Producto 2", Precio_unitario = 15.0m, Cantidad = 3, Subtotal = 45.0m });
            Items1.Add(new Producto { ID = 3, Productos = "Producto 3", Precio_unitario = 8.0m, Cantidad = 5, Subtotal = 40.0m });
            Items1.Add(new Producto { ID = 1, Productos = "Producto 1", Precio_unitario = 10.0m, Cantidad = 2, Subtotal = 20.0m });
            Items1.Add(new Producto { ID = 2, Productos = "Producto 2", Precio_unitario = 15.0m, Cantidad = 3, Subtotal = 45.0m });
            Items1.Add(new Producto { ID = 3, Productos = "Producto 3", Precio_unitario = 8.0m, Cantidad = 5, Subtotal = 40.0m });

            lstproductos.ItemsSource = Items1;
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
        public class Producto
        {
            public int ID { get; set; }
            public string Productos { get; set; }
            public decimal Precio_unitario { get; set; }
            public int Cantidad { get; set; }
            public decimal Subtotal { get; set; }
        }

        private void btntaco_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Tacos:";
        }

        private void btnmedia_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Medias:";
        }

        private void btnorden_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Orden:";
        }

        private void btnquesabirria_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Quesabirrias:";
        }

        private void btnrefrescos_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Refrescos:";
        }

        private void btnaguas_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Aguas:";
        }

        private void btnaguas1L_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Aguas1L:";
        }
        private void btncafes_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txtelemento.Text = "Cafés:";
        }

        private void btnextra_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
