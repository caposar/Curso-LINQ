namespace CursoLINQ.Modulo_6
{
    public class AllDemo
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
            // -  El método All determina si todos los elementos de una secuencia cumplen una condición.
            //
            // Nota:
            // El método All en LINQ es un operador de cuantificación que devuelve true si todos los elementos de una secuencia
            // de entrada (como una lista o matriz) cumplen con una condición específica (o si la secuencia está vacía),
            // y false si al menos un elemento no la cumple.
            // El método deja de ejecutarse en cuanto encuentra el primer elemento que no cumple la condición.
            // -----------------------------------------------------------------------------

            var sonTodasLasPersonasMayoresDeEdad = personas.All(p => p.Edad >= 18);

            var sonTodosSolteros = personas.All(p => p.Soltero);

            // En el caso de los cuantificadores, no existe una manera de utilizar sintaxis de queries con cuatificadores

        }
    }
}
