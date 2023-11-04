using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birrieria_LaPasadita.Clases
{
    internal class clsCliente
    {
        public clsCliente() { }
        public clsCliente(int cli_id)
        {
            this.cli_id = cli_id;
        }

        public clsCliente(int cli_id, string cli_nombre, string cli_apellidop, string cli_apellidom, string cli_telefono, string cli_domicilio)
        {
            this.cli_id = cli_id;
            this.cli_nombre = cli_nombre;
            this.cli_apellidop = cli_apellidop;
            this.cli_apellidom = cli_apellidom;
            this.cli_telefono = cli_telefono;
            this.cli_domicilio = cli_domicilio;
        }

        public int cli_id { get; set; }
        public string cli_nombre { get; set; }
        public string cli_apellidop { get; set; }
        public string cli_apellidom { get; set; }
        public string cli_telefono { get; set; }
        public string cli_domicilio { get; set; }
    }

}
