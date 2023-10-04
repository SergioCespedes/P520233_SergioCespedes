using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class UsuarioRol
    {
        //Primero digitamos las propiedades
        public int UsuarioRolID { get; set; }
        //esta forma de escribir la propiedad es autoimplemnetada, es mas sencilla
        //pero se pierde control en las funciones de get y set
        public string Rol { get; set; }
        //luego de escribir las props se digitan las funciones
        public DataTable Listar()
        {
            DataTable dataTable = new DataTable();
            //aca es donde viene la progra funcional para realizar el listar
            return dataTable;
        }
    }
}
