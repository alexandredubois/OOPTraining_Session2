using OOPTraining.Quest1;

namespace OOPTraining.Quest2
{
    public class Campus : PointOfInterest
    {
        //TODO 14) Faire hériter cette classe de la classe PointOfInterest

        //TODO 15) Ajouter une propriété Capacité d'accueil (Capacity) dans cette classe
        public int Capacity { get; set; }

        //QUESTION : Est-il nécessaire de re-déclarer les propriétés Latitude, Longitude, Name ? Pourquoi ?
        //TODO 16) Redéfinir la méthode toString pour qu'elle retourne une chaîne de caractère de la forme (NAME est un campus capable d'accueillir CAPACITY étudiants)
        //où NAME et CAPACITY seront remplacés par les valeurs des propriétés correspondantes

        public Campus(string name, double latitude, double longitude, int capacity)
        : base(name, latitude, longitude)
        {
            Capacity = capacity;
            Nature = PoiType.Campus;
        }

        public override string ToString()
        {
            return string.Format("{0} est un campus capable d'accueillir {1} étudiants", Name, Capacity);
        }
    }

    
}
