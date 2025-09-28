namespace CursoLINQ.Modulo_11
{
    public class ChunkDemo
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método Chunk divide una secuencia en fragmentos(o "trozos") de un tamaño especificado, devolviendo una secuencia de arreglos o listas.
            // 
            // Explicación:
            // El método Chunk es útil para procesar grandes colecciones en partes más pequeñas de manera secuencial.Es el método ideal cuando
            // necesitas, por ejemplo, enviar datos a una API que tiene límites de tamaño de lote o para crear sublistas para su procesamiento en paralelo.
            //
            // Comportamiento:
            // 1. Fragmentos (Chunks): El método devuelve una IEnumerable de arreglos(T[]) o de listas, donde cada arreglo interno tiene el tamaño especificado.
            // 2. Último Fragmento: Si el número total de elementos no es divisible exactamente por el tamaño del fragmento, el último fragmento
            // contendrá los elementos restantes, siendo de un tamaño menor al especificado.
            // 3. Versión: Fue introducido en.NET 6, simplificando operaciones que antes requerían bucles(for) o un uso complejo de Skip y Take.
            // -----------------------------------------------------------------------------

            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var resultado = A.Chunk(3);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
