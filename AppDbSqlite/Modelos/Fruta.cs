using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDbSqlite.Modelos
{
    internal class Fruta
    {
        public int FrutaID { get; set; }
        public String Nombre { get; set; }
        public String Color { get; set; }
        public String Cantidad { get; set; }
        public String PrecioKg { get; set; }
    }
}
