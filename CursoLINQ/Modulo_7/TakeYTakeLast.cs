namespace CursoLINQ.Modulo_7
{
    // Operadores de "paginación"
    public class TakeYTakeLast
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método Take devuelve un número especificado de elementos del principio de una secuencia.
            // 
            // Comportamiento:
            // Si count es mayor que el número de elementos en la secuencia, se devuelven todos los elementos de la secuencia.
            // Si count es menor o igual a cero, no se enumera la secuencia y se devuelve un IEnumerable<T> vacío.
            // 
            // - El método TakeLast devuelve un número especificado de elementos del final de una secuencia.
            // 
            // Comportamiento:
            // Similar a Take, si count es mayor que el número de elementos, se devuelven todos los elementos.
            // Si count es menor o igual a cero, se devuelve una secuencia vacía.
            // -----------------------------------------------------------------------------

            var numeros = Enumerable.Range(1, 100);

            var primeros10Numeros = numeros.Take(10).ToList();

            var ultimos10Numeros = numeros.TakeLast(10).ToList();

            // Sintaxis de queries
            var primeros10Numeros_2 = (from n in numeros
                                       select n).Take(10);
        }
    }
}
