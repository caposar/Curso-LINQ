namespace CursoLINQ.Modulo_2
{
    public class OfTypeDemo
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método OfType filtra una secuencia para devolver solo los elementos de un tipo específico.
            // -----------------------------------------------------------------------------

            var listado = new List<object>() { "Felipe", 1, 2, "Claudia", true };

            var strings = listado.OfType<string>();
            var numeros = listado.OfType<int>();

            // sintaxis de queries
            var strings_2 = from s in listado.OfType<string>()
                            select s;

            // Ejemplo 2: herencia

            var listadoAnimales = new List<Animal>()
                                    {
                                        new Perro(){Nombre = "Firulais"},
                                        new Gato(){Nombre = "Félix"}
                                    };

            var perros = listadoAnimales.OfType<Perro>();
        }

        public abstract class Animal
        {
            public abstract string? Nombre { get; set; }
        }

        public class Perro : Animal
        {
            public override string? Nombre { get; set; }
        }

        public class Gato : Animal
        {
            public override string? Nombre { get; set; }
        }
    }
}
