namespace CursoLINQ.Modulo_11
{
    public class SequenceEqualDemo
    {
        public void Ejemplo()
        {
            // -----------------------------------------------------------------------------
            // - El método SequenceEqual determina si dos secuencias son idénticas en cuanto a la cantidad de elementos, su orden y sus valores.
            // -----------------------------------------------------------------------------


            string[] A = { "felipe", "fernando" };

            string[] B = { "felipe", "fernando" };

            string[] C = { "FEliPE", "FernandO" };

            string[] D = { "fernando", "felipe" };

            var AB = A.SequenceEqual(B);

            var AC = A.SequenceEqual(C);

            var ACSinImportarMayusculas = A.SequenceEqual(C, StringComparer.OrdinalIgnoreCase);

            var AD = A.SequenceEqual(D);

            // Nota: no existe sintaxis de query para este código.
        }
    }
}
