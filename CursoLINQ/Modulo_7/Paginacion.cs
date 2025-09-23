namespace CursoLINQ.Modulo_7
{
    public class Paginacion
    {
        public void Ejemplo()
        {
            var numeros = Enumerable.Range(1, 100);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Página {i}");
                var paginado = numeros.Paginar(i, 10);
                foreach (var item in paginado)
                {
                    Console.WriteLine(item);
                }
            }
        }

        
        public void Ejemplo2()
        {
            var numeros = Enumerable.Range(1, 101);

            // Cantidad total de elementos de la colección
            int cantidadElementos = numeros.Count();

            // Cantidad de elementos que quiero mostrar por página
            int elementosPorPagina = 10;

            // Cantidad de páginas necesarias para mostrar todos los elementos de la colección
            int paginas = (int)Math.Ceiling((double)cantidadElementos / elementosPorPagina);
            
            Console.WriteLine("paginas: ", paginas);

            for (int i = 1; i <= paginas; i++)
            {
                Console.WriteLine($"Página {i}");
                var paginado = numeros.Paginar(i, elementosPorPagina);
                foreach (var item in paginado)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }

    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Paginar<T>(this IEnumerable<T> coleccion, int pagina, int tamañoLote)
        {
            return coleccion.Skip((pagina - 1) * tamañoLote).Take(tamañoLote);
        }
    }
}
