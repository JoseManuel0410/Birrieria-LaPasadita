using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace Birrieria_LaPasadita.Formularios
{
    /// <summary>
    /// Lógica de interacción para frmordenes.xaml
    /// </summary>
    public partial class frmordenes : Window
    {
        ObservableCollection<Producto> listaProductos = new ObservableCollection<Producto>();
        public frmordenes()
        {
            InitializeComponent();
            lstProductos.ItemsSource = listaProductos;
            // Agrega algunos productos de ejemplo a la lista
            listaProductos.Add(new Producto { Nombre = "Producto 1", PrecioUnitario = 10, Cantidad = 1, Subtotal = 10});
            listaProductos.Add(new Producto { Nombre = "Producto 2", PrecioUnitario = 15, Cantidad = 2, Subtotal = 20 });
            listaProductos.Add(new Producto { Nombre = "Producto 3", PrecioUnitario = 20, Cantidad = 3, Subtotal = 30 });
            listaProductos.Add(new Producto { Nombre = "Producto 4", PrecioUnitario = 25, Cantidad = 4, Subtotal = 40 });
            listaProductos.Add(new Producto { Nombre = "Producto 5", PrecioUnitario = 30, Cantidad = 5, Subtotal = 50 });
            listaProductos.Add(new Producto { Nombre = "Producto 6", PrecioUnitario = 35, Cantidad = 6, Subtotal = 60 });
        }
        private void EliminarProducto_Click(object sender, RoutedEventArgs e)
        {
            if (lstProductos.SelectedItem is Producto producto)
            {
                listaProductos.Remove(producto);
            }
        }

        // Boton para ir al formulario de Empleados
        private void btnempleados_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmempleados x = new Formularios.frmempleados();
            x.Show();
            this.Close();
        }
        private void btnventas_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmventas x = new Formularios.frmventas();
            x.Show();
            this.Close();
        }
        private void btntaco_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txbelemento.Text = "Tacos:";
            
        }
        private void btnmedia_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txbelemento.Text = "Medias:";
        }
        private void btnorden_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txbelemento.Text = "Orden:";
        }
        private void btnquesabirria_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txbelemento.Text = "Quesabirrias:";
        }
        private void btnrefrescos_Click(object sender, RoutedEventArgs e)
        {
            txtcantidad.Clear();
            txtcantidad.Focus();
            txbelemento.Text = "Refrescos:";
        }

        private void btnclientes_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmclientes x = new Formularios.frmclientes();
            x.Show();
            this.Close();
        }
    }
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal Subtotal { get; set; }
    }
}
