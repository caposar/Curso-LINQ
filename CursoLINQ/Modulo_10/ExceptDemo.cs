namespace CursoLINQ.Modulo_10
{
    public class ExceptDemo
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
            // - El método Except produce la diferencia de conjuntos, devolviendo los elementos de la primera secuencia que no están en la segunda.
            // - El método ExceptBy produce la diferencia de conjuntos basándose en una clave,
            // devolviendo los elementos de la primera secuencia que no tienen una clave coincidente en la segunda.
            // -----------------------------------------------------------------------------

            int[] A = { 1, 2, 3 };

            int[] B = { 1, 15 };

            var NumerosEnAQueNoEstanEnB = A.Except(B);

            var personasBNombres = personasB.Select(x => x.Nombre);
            var personasEnAQueNoEstanEnB = personasA.ExceptBy(personasBNombres, x => x.Nombre);

        }
    }
}
