using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryPerezIEFI
{
    internal class Conexion
    {
        public static string ObtenerCadena()
        {
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LoguinIEFI.accdb");
            return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={ruta}";
        }
    }
}
