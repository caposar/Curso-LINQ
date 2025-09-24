using System.Text.RegularExpressions;

namespace CursoLINQ.Modulo_8
{
    public class GroupByDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
                new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
                new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
            };

            // -----------------------------------------------------------------------------
            // - El método GroupBy agrupa los elementos de una secuencia en colecciones basadas en una clave común.
            // -----------------------------------------------------------------------------

            var agrupamientoPorSolteria = personas.GroupBy(p => p.Soltero);

            // sintaxis de queries
            var agrupamientoPorSolteria_2 = from p in personas
                                            group p by p.Soltero into grupos
                                            select grupos;

            foreach (var grupo in agrupamientoPorSolteria_2)
            {
                Console.WriteLine($"Grupo de las personas donde Soltero = {grupo.Key} (Total: {grupo.Count()})");
                foreach (var persona in grupo)
                {
                    Console.WriteLine($"- {persona.Nombre}");
                }
            }

        }
    }
}
