namespace CursoLINQ.Modulo_6
{
    public class AnyDemo
    {
        public void Ejemplo()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
            };

            // -----------------------------------------------------------------------------
            // - El método Any determina si cualquier elemento de una secuencia cumple una condición.
            // 
            // Nota:
            // El método Any en LINQ es un operador de cuantificación que devuelve true si encuentra al menos
            // un elemento que cumpla la condición específica.
            // Devuelve false si ningún elemento cumple la condición o si la secuencia está vacía.
            // El método deja de ejecutarse en cuanto encuentra el primer elemento que cumple la condición.
            // -----------------------------------------------------------------------------

            var existeMenor = personas.Any(p => p.Edad < 18);

            var existePersonaMayorDe20 = personas.Any(p => p.Edad > 20);

        }
    }
}
