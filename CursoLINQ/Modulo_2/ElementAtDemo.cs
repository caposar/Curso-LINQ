using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CursoLINQ.Modulo_2
{
    public class ElementAtDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
            };

            // -----------------------------------------------------------------------------

            // El método ElementAt retorna el elemento en la posición especificada de una secuencia.
            // Lanza una excepción de tipo ArgumentOutOfRangeException si el índice está fuera del rango de la secuencia.

            // El método ElementAtOrDefault retorna el elemento en la posición especificada ó el valor por defecto del tipo si el índice está fuera del rango de la secuencia.

            // -----------------------------------------------------------------------------
            var terceraPersona = personas.ElementAt(2);

            // -----------------------------------------------------------------------------
            // Sintaxis 1: Sintaxis de métodos (Sintaxis de Lambda)
            var sextaPersona = personas.ElementAtOrDefault(5);

            // Sintaxis 2: Sintaxis de queries
            var sextaPersona_2 = (from p in personas
                                  select p).ElementAtOrDefault(5);
        }
    }
}
