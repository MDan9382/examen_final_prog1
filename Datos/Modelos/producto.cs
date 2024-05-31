using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final_prog1.Datos.Modelos
{
    internal class producto
    {
        public decimal id {  get; set; }
        public string nombre { get; set; }
        public decimal precio { get; set; }
        public decimal existencias { get; set; }
        public decimal en_tienda { get; set;}
        public string categoria { get; set; }
        public string marca { get; set; }
    }
}
