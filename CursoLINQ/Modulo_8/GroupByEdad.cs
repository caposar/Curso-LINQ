using static CursoLINQ.Modulo_2.OfTypeDemo;

namespace CursoLINQ.Modulo_8
{
    public class GroupByEdad
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

            var agrupamientoPorRangoEdad = personas.GroupBy(p => p.Edad / 5);

            // Cuando haces Edad / 5, estás tomando la edad de cada persona y dividiéndola por 5 usando división entera (int).
            // Eso significa que el resultado será un número entero que representa el rango de 5 en el que cae esa edad.
            //
            // Ejemplos:
            // 17 / 5 = 3
            // 18 / 5 = 3
            // 19 / 5 = 3
            // 25 / 5 = 5
            // 27 / 5 = 5
            // 30 / 5 = 6
            // 45 / 5 = 9
            //
            // Por lo tanto, el Key del grupo no es la edad exacta, sino el número de rango.

            // Sintaxis de queries

            var agrupamientoPorRangoEdad_2 = from p in personas
                                             group p by p.Edad / 5 into grupos
                                             select grupos;

            foreach (var grupo in agrupamientoPorRangoEdad_2)
            {
                Console.WriteLine($"Grupo de las personas en el rango de edad {grupo.Key * 5} - {grupo.Key * 5 + 5 - 1}");

                foreach (var persona in grupo)
                {
                    Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
                }
            }

        }

        public void Ejemplo2()
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

            int rango = 10;

            var agrupamientoPorRangoEdad = from p in personas
                                           group p by p.Edad / rango into grupos
                                           select grupos;

            foreach (var grupo in agrupamientoPorRangoEdad)
            {
                int rangoMin = grupo.Key * rango;
                int rangoMax = rangoMin + rango - 1;

                Console.WriteLine($"Grupo de las personas en el rango de edad {rangoMin} - {rangoMax}");

                foreach (var persona in grupo)
                {
                    Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
                }
            }
        }
    }
}
