namespace CursoLINQ.Modulo_11
{
    public class ConcatDemo
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método Concat une dos secuencias en una sola secuencia, sin eliminar duplicados.
            // 
            // Nota:
            // * Concat es el operador LINQ más simple para combinar colecciones. Toma una secuencia y le añade
            // todos los elementos de una segunda secuencia al final. Es una concatenación o adición directa.
            // * La característica clave de Concat es que mantiene todos los duplicados. Si el mismo elemento aparece en
            // ambas listas, o varias veces en una sola, aparecerá la misma cantidad de veces en la secuencia de salida.
            // * Si necesitas eliminar duplicados después de unir, debes usar el método Union o UnionBy.
            // -----------------------------------------------------------------------------

            int[] A = { 1, 2, 3 };

            int[] B = { 4, 5, 6 };

            var resultado = A.Concat(B);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
