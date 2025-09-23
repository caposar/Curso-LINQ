namespace CursoLINQ.Modulo_5
{
    public class Agregado
    {
        public void Ejemplo()
        {
            // - El método Aggregate aplica una función acumulativa a una secuencia para producir un único valor.
            // 
            // Explicación
            // Aggregate es el método LINQ más versátil para operaciones de agregación. Te permite realizar cálculos complejos
            // o transformaciones sobre una secuencia, combinando cada elemento con el resultado acumulado de los elementos anteriores.
            // Es como un bucle foreach manual, pero encapsulado en una sola llamada a método.
            // 
            // El método necesita tres partes para funcionar:
            // 1. La secuencia de entrada: Los elementos sobre los que se va a operar.
            // 2. Un valor inicial (semilla o "seed"): El valor con el que comienza la acumulación.
            // 3. La función de agregación: Una función que toma el valor acumulado actual y el siguiente elemento de la secuencia para producir un nuevo valor acumulado.

            var numeros = Enumerable.Range(1, 5);

            var resultado = numeros.Aggregate((a, b) => a * b); // 1x2x3x4x5

            Console.WriteLine("Resultado es " + resultado);

            var resultadoConValorInicial = numeros.Aggregate(10, (a, b) => a * b); // 10x1x2x3x4x5

            Console.WriteLine("El resultado con el valor semilla es: " + resultadoConValorInicial);
        }
    }
}
