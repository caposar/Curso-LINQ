namespace CursoLINQ.Modulo_5
{
    public class Promedio
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
            // - El método Average calcula el promedio de los valores numéricos de una secuencia.
            // -----------------------------------------------------------------------------

            var numeros = Enumerable.Range(1, 5);

            Console.WriteLine($"El promedio de los números es {numeros.Average()}");

            Console.WriteLine($"El promedio de las edades es {personas.Average(p => p.Edad)}");

        }
    }
}
