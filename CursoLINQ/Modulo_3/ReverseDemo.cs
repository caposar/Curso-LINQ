using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLINQ.Modulo_3
{
    public class ReverseDemo
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

            // El método Reverse invierte el orden de los elementos de una secuencia.
            // Es IMPORTANTE diferenciar entre dos versiones de este método:

            // List<T>.Reverse() (Método de instancia)
            // El método Reverse() de la clase List<T> es un método de instancia que modifica la lista original en su lugar.
            // No devuelve nada (void), por lo que no se puede asignar el resultado a una variable.

            // Ejemplo:
            var personas2 = new List<string> { "Ana", "Juan", "Pedro" };
            personas2.Reverse(); // La lista 'personas' ahora es ["Pedro", "Juan", "Ana"]
                                 // var revertido = personas.Reverse(); // Esto da error de compilación

            // Enumerable.Reverse() (Método de extensión LINQ)
            // El método Reverse() de LINQ es un método de extensión que opera sobre cualquier IEnumerable.
            // Este método sí devuelve una nueva secuencia (IEnumerable) con los elementos en orden inverso, sin modificar la colección original.

            // Ejemplo:
            var personas3 = new List<string> { "Ana", "Juan", "Pedro" };
            var personasRevertidas = personas3.AsEnumerable().Reverse(); // Devuelve un IEnumerable<string>

            // -----------------------------------------------------------------------------

            var numeros = Enumerable.Range(1, 20).Reverse();

            // sintaxis de queries
            var numeros_2 = from n in Enumerable.Range(1, 20).Reverse()
                            select n;

            //personas.Reverse();

            var personasInvertido = personas.AsEnumerable().Reverse().ToList();
        }
    }
}
