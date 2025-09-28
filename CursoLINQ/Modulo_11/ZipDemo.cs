namespace CursoLINQ.Modulo_11
{
    public class ZipDemo
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método Zip combina dos (o tres, desde .NET 6) secuencias en una nueva 
            //   secuencia, emparejando los elementos de la misma posición.
            //
            // Comportamiento:
            // La secuencia resultante tendrá la longitud de la secuencia más corta.
            // La evaluación es diferida y no modifica las colecciones originales.
            //
            // Sobrecarga Clásica (2 secuencias):
            // Requiere una función (selectora) que define cómo combinar el par de elementos 
            // emparejados (por ejemplo, crear un nuevo objeto).
            //
            // Sobrecarga Moderna (NET 6+, 2 secuencias):
            // Permite omitir la función. En este caso, devuelve una secuencia de tuplas de valor 
            // (ValueTuple) con los elementos emparejados (ej. IEnumerable<(int, int)>).
            //
            // Versión de 3 secuencias (NET 6+):
            // Solo admite la forma sin función selectora, devolviendo tuplas de valor con tres 
            // elementos (ej. IEnumerable<(T1, T2, T3)>).
            // -----------------------------------------------------------------------------

            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };

            var combinados = A.Zip(B);
            foreach (var combinacion in combinados)
            {
                Console.WriteLine($"({combinacion.First}, {combinacion.Second})");
            }

            var resultado = A.Zip(B, (a, b) => a * b);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
