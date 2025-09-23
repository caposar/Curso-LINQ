namespace CursoLINQ.Modulo_5
{
    public class Conteo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Soltero = true },
                new Persona { Nombre = "Nidia", Soltero = true },
                new Persona { Nombre = "Alejandro", Soltero = true },
                new Persona { Nombre = "Valentina", Soltero = false }
            };

            // -----------------------------------------------------------------------------
            // - El método Count devuelve el número de elementos en una secuencia.
            // -----------------------------------------------------------------------------

            Console.WriteLine($"La cantidad de personas es {personas.Count()}");

            Console.WriteLine($"La cantidad de personas solteras es {personas.Count(p => p.Soltero)}");

            Console.WriteLine($"Int max = {int.MaxValue.ToString("N")}");

            //personas.LongCount();

            // Sintaxis de queries (no muy útil en estos casos)

            var conteoSolteros = (from p in personas
                                  where p.Soltero
                                  select p).Count();
        }
    }
}
