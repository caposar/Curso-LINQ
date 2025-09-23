namespace CursoLINQ.Modulo_5
{
    public class SumMaxMin
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", Edad = 19, },
                            new Persona { Nombre = "Nidia", Edad = 25 },
                            new Persona { Nombre = "Alejandro", Edad = 30 },
                            new Persona { Nombre = "Valentina", Edad = 22 }
                            };

            // -----------------------------------------------------------------------------
            // - El método Sum calcula la suma de los valores numéricos de una secuencia.
            // - El método Max devuelve el valor máximo de una secuencia.
            // - El método Min devuelve el valor mínimo de una secuencia.
            // -----------------------------------------------------------------------------

            var numeros = Enumerable.Range(1, 5);

            Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
            Console.WriteLine($"La suma de los numeros es {personas.Sum(p => p.Edad)}");

            Console.WriteLine($"La edad máxima de las personas es {personas.Max(x => x.Edad)}");
            Console.WriteLine($"La edad mínima de las personas es {personas.Min(x => x.Edad)}");
        }
    }
}
