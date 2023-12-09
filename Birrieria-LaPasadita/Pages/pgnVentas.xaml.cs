using Birrieria_LaPasadita.Clases;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Lógica de interacción para pgnVentas.xaml
    /// </summary>
    public partial class pgnVentas : Page
    {
        public pgnVentas()
        {
            InitializeComponent();
            ObservableCollection<clsVentas> lista = new ObservableCollection<clsVentas>(GetDataBase.ObtenerVentas(clsconexion.Conectar()));
            dtgdVentas.ItemsSource = lista;
        }
    }
}
