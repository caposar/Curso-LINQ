namespace CursoLINQ.Modulo_10
{
    public class DistinctDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Eduardo"},
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            // -----------------------------------------------------------------------------
            // - El método Distinct elimina los elementos duplicados de una secuencia, devolviendo solo los elementos únicos.
            // - El método DistinctBy elimina los elementos duplicados de una secuencia basándose en una propiedad o clave específica.
            // -----------------------------------------------------------------------------

            int[] numeros = { 1, 2, 3, 1, 1, 6 };

            var numerosSinRepeticiones = numeros.Distinct();

            var personasSinNombresRepetidos = personas.DistinctBy(x => x.Nombre);

            // Sintaxis de queries
            var numerosSinRepeticiones_2 = from n in numeros.Distinct()
                                           select n;

            var personasSinNombresRepetidos_2 = from p in personas.DistinctBy(x => x.Nombre)
                                                select p;
        }
    }
}
