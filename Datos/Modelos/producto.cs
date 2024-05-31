using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final_prog1.Datos.Modelos
{
    internal class producto
    {
        public decimal Id {  get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public decimal Existencias { get; set; }
        public decimal En_tienda { get; set;}
        public string Categoria { get; set; }
        public string Marca { get; set; }

        //constructor para los parametros
        public producto(decimal id, string nombre, decimal precio, decimal existencias, decimal en_tienda, string categoria, string marca)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Existencias = existencias;
            En_tienda = en_tienda;
            Categoria = categoria;
            Marca = marca;
        }
        public producto() { }
    }
}
