using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }
        public string CodigoBarras { get; set;}
        public string NombreProducto { get; set;}
        public decimal Costo { get; set; }
        public decimal Utilidad { get; set;}
        public decimal SubTotal { get; set;}
        public decimal TasaImpuesto { get; set;}
        public decimal CantidadStock { get; set;}
        public bool Actiuvo { get; set; }
        
        ProductoCategoria MiCategoria { get; set;}

        public Producto() 
        {
            MiCategoria = new ProductoCategoria();
        }

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
        public bool ConsultarPorProductoID(int ProductoID)
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public bool ConsultarPorCodigoBarras(string CodigoBarras)
        {
            bool Respuesta = false;

            return Respuesta;
        }

        public DataTable Listar(bool VerActivos = true)
        {
            DataTable dataTable = new DataTable();

            return dataTable;
        }
    }
}
