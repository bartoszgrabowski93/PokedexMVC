namespace Workshops.Patterns
{
    public sealed class Singleton
    {
        // prywatny konstruktor, publiczna metoda
        // jedna instancja, jeden obiekt
        /* Singleton jest wykorzystywany wszędzie tam, ... operacje na plikach, bazach danych, repozytoriach. Bazy danych nie lubią wielu instancji, dlatego wolą singletony */

        private static Singleton instance;
        public Singleton Get()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }
    }
}
