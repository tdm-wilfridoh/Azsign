using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azsign
{
    public static class Utility
    {
        public static string ConvertirFechaToW3C(string fechaOriginal)
        {
            DateTime fechaDateTime = DateTime.ParseExact(fechaOriginal, "yyyy-MM-dd HH:mm:ss", null);

            // Convertirla al formato W3C XML Schema (ISO 8601) utilizando la cadena "o"
            string fechaW3C = fechaDateTime.ToString("o");
            return fechaW3C;
        }
    }
}
