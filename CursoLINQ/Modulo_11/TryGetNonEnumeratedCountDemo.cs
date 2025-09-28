namespace CursoLINQ.Modulo_11
{
    public class TryGetNonEnumeratedCountDemo
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método TryGetNonEnumeratedCount intenta obtener el número total de elementos
            // en una secuencia sin necesidad de recorrerla.
            //
            // 📖 Explicación
            // Introducido en .NET 6, está pensado para optimizar el rendimiento en operaciones
            // que necesitan el tamaño de la colección, evitando enumeraciones costosas.
            //
            // 🔍 Propósito
            // Evitar el costo de recorrer toda la secuencia. Esto es especialmente útil si la
            // fuente de datos es lenta (ej. consulta a base de datos, servicio web, iteradores).
            //
            // ❓ Funcionamiento
            // - Devuelve un booleano:
            //   - true → La colección expone su tamaño directamente (ej. List<T>, T[], ICollection<T>).
            //            En ese caso, 'count' se asigna y la operación es instantánea.
            //   - false → La colección no puede informar su tamaño sin ser enumerada
            //             (ej. resultados de Where, Select o iteradores con yield).
            //             En ese caso, el valor de 'count' no debe usarse.
            //
            // 💡 Uso típico
            // Antes de llamar a Count():
            //
            // if (coleccion.TryGetNonEnumeratedCount(out var count))
            // {
            //     Console.WriteLine($"Conteo instantáneo: {count}");
            // }
            // else
            // {
            //     Console.WriteLine("Conteo lento. Usando Count()...");
            //     var conteoReal = coleccion.Count();
            // }
            // -----------------------------------------------------------------------------

            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var conteo = 0;
            var pudoContarASinEnumerar = A.TryGetNonEnumeratedCount(out conteo);

            var personasA = new List<Persona>()
            {
                new Persona{Nombre = "Eduardo", EmpresaId = 1},
                new Persona{Nombre = "Nidia", EmpresaId = 1},
                new Persona{Nombre = "Esmerlin", EmpresaId = 3}
            };

            var personasCollection = new PersonasCollection();
            personasCollection.AddRange(personasA);

            var conteoPersonas2 = 0;
            var pudoContarPersonasSinEnumerar = personasCollection.TryGetNonEnumeratedCount(out conteoPersonas2);
        }

        public class PersonasCollection : IEnumerable<Persona>, ICollection<Persona>
        {
            private readonly List<Persona> _personas = new List<Persona>();

            public int Count => _personas.Count;

            public bool IsReadOnly => throw new NotImplementedException();

            public void Add(Persona persona)
            {
                _personas.Add(persona);
            }

            public void AddRange(IEnumerable<Persona> personas)
            {
                _personas.AddRange(personas);
            }

            public void Clear()
            {
                throw new NotImplementedException();
            }

            public bool Contains(Persona item)
            {
                throw new NotImplementedException();
            }

            public void CopyTo(Persona[] array, int arrayIndex)
            {
                throw new NotImplementedException();
            }

            public IEnumerator<Persona> GetEnumerator()
            {
                return _personas.GetEnumerator();
            }

            public bool Remove(Persona item)
            {
                throw new NotImplementedException();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<Persona>)_personas).GetEnumerator();
            }
        }
    }
}
