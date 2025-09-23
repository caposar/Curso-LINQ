namespace CursoLINQ.Modulo_5
{
    public class MaxByMinBy
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
            // - El método MaxBy devuelve el elemento con el valor máximo para una propiedad o clave específica.
            // - El método MinBy devuelve el elemento con el valor mínimo para una propiedad o clave específica.
            // -----------------------------------------------------------------------------

            var numeros = Enumerable.Range(1, 5);

            Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
            Console.WriteLine($"La suma de los numeros es {personas.Sum(p => p.Edad)}");

            Console.WriteLine($"La edad máxima de las personas es {personas.Max(x => x.Edad)}");
            Console.WriteLine($"La edad mínima de las personas es {personas.Min(x => x.Edad)}");

            var personaDeMayorEdad = personas.MaxBy(x => x.Edad);
            var personaDeMenorEdad = personas.MinBy(x => x.Edad);
        }
    }
}
