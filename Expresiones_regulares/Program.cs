using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Expresiones_regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            string patron;
            patron = "[0-9]+";//Para buscar un valor dado en la cadena de texto.
            string[] cadena = { "uno1dos2tres3cuatro" }; //elimina lo numero y lo divide en cuatro parte
            foreach (string texto in cadena)
                Console.WriteLine(Regex.Replace(texto, patron, "\n"));//Remplaza lo valores numerico en salto de linea;
            Console.ReadKey();
        }
    }
}
