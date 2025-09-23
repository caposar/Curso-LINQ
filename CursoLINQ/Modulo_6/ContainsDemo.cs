namespace CursoLINQ.Modulo_6
{
    public class ContainsDemo
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método Contains determina si una secuencia contiene un elemento específico.
            // -----------------------------------------------------------------------------

            var numeros = Enumerable.Range(1, 5);

            var estaElNumero3 = numeros.Contains(3);

            var estaElNumero20 = numeros.Contains(20);

        }
    }
}
