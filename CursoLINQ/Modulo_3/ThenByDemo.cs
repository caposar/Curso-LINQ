namespace CursoLINQ.Modulo_3
{
    public class ThenByDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            };

            // -----------------------------------------------------------------------------
            // - ThenBy ordena una secuencia por un segundo criterio de forma ascendente.
            // Se utiliza después de OrderBy o OrderByDescending para manejar los "empates".
            // - ThenByDescending ordena una secuencia por un segundo criterio de forma descendente.
            // Al igual que ThenBy, se usa para desempates después de un ordenamiento principal.
            // -----------------------------------------------------------------------------

            var personasOrdenadasPorEdad = personas.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

            foreach (var persona in personasOrdenadasPorEdad)
            {
                Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
            }

            // Sintaxis de queries

            var personasOrdenadasPorEdad_2 = from p in personas
                                             orderby p.Edad, p.Nombre descending
                                             select p;
        }
    }
}
