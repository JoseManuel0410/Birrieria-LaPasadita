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
    /// Lógica de interacción para frmventas.xaml
    /// </summary>
    public class Venta
    {
        public DateTime FechaRegistro { get; set; }
        public string NumeroDocumento { get; set; }
        public double MontoTotal { get; set; }
        public string UsuarioRegistro { get; set; }
        public string NombreCliente { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public double PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public double Subtotal { get; set; }
    }
    public partial class frmventas : Window
    {
        public frmventas()
        {
            InitializeComponent();

            ObservableCollection<Venta> ventas = new ObservableCollection<Venta>();

            ventas.Add(new Venta
            {
                FechaRegistro = DateTime.Now,
                NumeroDocumento = "001",
                MontoTotal = 100.00,
                UsuarioRegistro = "Usuario1",
                NombreCliente = "Cliente1",
                CodigoProducto = "P001",
                NombreProducto = "Producto1",
                PrecioUnitario = 10.00,
                Cantidad = 5,
                Subtotal = 50.00
            });

            ventas.Add(new Venta
            {
                FechaRegistro = DateTime.Now.AddDays(-1),
                NumeroDocumento = "002",
                MontoTotal = 75.00,
                UsuarioRegistro = "Usuario2",
                NombreCliente = "Cliente2",
                CodigoProducto = "P002",
                NombreProducto = "Producto2",
                PrecioUnitario = 15.00,
                Cantidad = 3,
                Subtotal = 45.00
            });

            // Establecer la colección como origen de datos del DataGrid
            dtgdVentas.ItemsSource = ventas;
        }

        private void btnordenes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnempleados_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnclientes_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmclientes x = new Formularios.frmclientes();
            x.Show();
            this.Close();
        }

        private void btnventas_Click(object sender, RoutedEventArgs e)
        {
            Formularios.frmventas x = new Formularios.frmventas();
            x.Show();
            this.Close();
        }
    }
}
