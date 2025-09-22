using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_1
{
    public class EjecucionDiferida
    {
        public void Ejemplo()
        {
            //int[] numeros = { 1, 2, 3, 4, 5 };
            int[] numeros = Enumerable.Range(1, 5).ToArray();

            // -----------------------------------------------------------------------------
            // Sintaxis 1: Sintaxis de métodos (Sintaxis de Lambda)
            //var numerosPares = numeros.Where(n => n % 2 == 0).ToList();

            // Sintaxis 2: Sintaxis de queries
            //var numerosPares2 = (from n in numeros
            //                    where n % 2 == 0
            //                    select n).ToList();

            //int[] numeros = Enumerable.Range(1, 5).ToArray();

            // -----------------------------------------------------------------------------
            var numerosPares = numeros.Where(n =>
            {
                Console.WriteLine($"Evaluando si {n} es par");
                return n % 2 == 0;
            }).ToList();

            foreach (var numero in numerosPares)
            {
                Console.WriteLine($"Si, el {numero} es par.");
            }

        }
    }
}
