namespace CursoLINQ.Modulo_10
{
    public class IntersectDemo
    {
        public void Ejemplo()
        {
            var personasA = new List<Persona>() {
                            new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                            new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                            new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
                            };

            var personasB = new List<Persona>()
                                {
                                    new Persona{Nombre = "Fernando", Edad = 25},
                                    new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                                };

            // -----------------------------------------------------------------------------
            // - El método Intersect produce la intersección de conjuntos, devolviendo los elementos que se encuentran en ambas secuencias.
            // - El método IntersectBy produce la intersección de conjuntos basándose en una clave,
            // devolviendo los elementos de la primera secuencia que tienen una clave coincidente en la segunda.
            // -----------------------------------------------------------------------------

            int[] A = { 1, 2, 3 };

            int[] B = { 1, 15 };

            var numerosQueEstanEnAyB = A.Intersect(B);

            var personasBNombres = personasB.Select(x => x.Nombre);
            var personasQueEstanEnAyB = personasA.IntersectBy(personasBNombres, x => x.Nombre);

        }
    }
}
