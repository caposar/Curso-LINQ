namespace CursoLINQ.Modulo_2
{
    internal class WhereDemo
    {
        public void Ejemplo()
        {
            //int[] numeros = Enumerable.Range(1, 20).ToArray();
            int[] numeros = [.. Enumerable.Range(1, 20)];

            // -----------------------------------------------------------------------------
            //var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();

            //Console.WriteLine("Los números impares son:");
            //foreach (var numero in numerosImpares)
            //{
            //    Console.WriteLine(numero);
            //}

            // -----------------------------------------------------------------------------
            // Sintaxis 1: Sintaxis de métodos (Sintaxis de Lambda)
            var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();

            // Sintaxis 2: Sintaxis de queries
            var numerosImparesMayoresQue10_2 = from n in numeros
                                               where n % 2 == 1 && n > 10
                                               select n;

            Console.WriteLine("Los números impares mayores que 10 son:");
            foreach (var numero in numerosImparesMayoresQue10_2)
            {
                Console.WriteLine(numero);
            }

        }
    }
}
