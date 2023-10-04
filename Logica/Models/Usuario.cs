using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Usuario
    {
        public Usuario()
        {
            MiUsuarioRol = new UsuarioRol();
        }

        public int UsuarioID { get; set; }

        public string Cedula { get; set; }

        public string Nombre { get; set; }
        public string Correo { get; set; }

        public string Contrasennia { get; set; }

        public string Telefono { get; set; }

        public string Tipo { get; set; }

        public string Direccion { get; set; }

        public bool Activo { get; set; }

        public UsuarioRol MiUsuarioRol { get; set; }

        //comportamientos ,operaciones , funciones, metodos


        public bool Agregar()
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public bool Actualizar()
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public bool Eliminar()
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public bool ConsultarPorID()
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public bool ConsultaPorCedula(string Cedula)
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public bool ConsultaPorCorreo(string Correo)
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public DataTable ListarActivos()
        {
            DataTable dataTable = new DataTable();

            return dataTable;
        }

        public DataTable ListarInactivos()
        {
            DataTable dataTable = new DataTable();

            return dataTable;
        }
    }

}
}
