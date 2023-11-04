using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Birrieria_LaPasadita.Clases
{
    public class clsEmpleado
    {
        public clsEmpleado() { }
        public clsEmpleado(int emp_id)
        {
            this.emp_id = emp_id;
        }

        public clsEmpleado(int emp_id, string emp_nombre, string emp_apellidop, string emp_apellidom, string emp_telefono, string emp_cargo, string emp_direccion)
        {
            this.emp_id = emp_id;
            this.emp_nombre = emp_nombre;
            this.emp_apellidop = emp_apellidop;
            this.emp_apellidom = emp_apellidom;
            this.emp_telefono = emp_telefono;
            this.emp_cargo = emp_cargo;
            this.emp_direccion = emp_direccion;
        }

        public int emp_id { get; set; }
        public string emp_nombre { get; set; }
        public string emp_apellidop { get; set; }
        public string emp_apellidom { get; set; }
        public string emp_telefono { get; set; }
        public int emp_cargo { get; set; }
        public string emp_direccion { get; set; }

        public string emp_estado { get; set; }

        public string consultar()
        {
            return "SELECT emp_nombre,emp_telefono,emp_apellidop,emp_apellidom,emp_cargo,emp_direccion FROM EMPLEADO WHERE emp_id=" + this.emp_id + "";

        }

        public string Query
        {
            get
            {
                return "SELECT emp_nombre,emp_telefono,emp_apellidop,emp_apellidom,emp_cargo,emp_direccion FROM EMPLEADO WHERE emp_id=" + this.emp_id + "";
            }
        }
    }
}
