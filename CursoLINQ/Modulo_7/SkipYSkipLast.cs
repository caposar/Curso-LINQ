namespace CursoLINQ.Modulo_7
{
    // Operadores de "paginación"
    public class SkipYSkipLast
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método Skip omite un número especificado de elementos del principio de una secuencia y devuelve el resto.
            // - El método SkipLast omite un número especificado de elementos del final de una secuencia y devuelve el resto.
            // -----------------------------------------------------------------------------

            var numeros = Enumerable.Range(1, 100);

            var primeros10Numeros = numeros.Take(10).ToList();
            var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();

            var ultimos10Numeros = numeros.TakeLast(10).ToList();
            var penultimoLote = numeros.SkipLast(10).TakeLast(10).ToList();
        }
    }
}
