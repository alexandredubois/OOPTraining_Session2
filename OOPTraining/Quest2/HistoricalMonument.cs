using OOPTraining.Quest1;

namespace OOPTraining.Quest2
{
    public class HistoricalMonument : PointOfInterest
    {
        //TODO 17) Faire hériter cette classe de la classe PointOfInterest
        //TODO 18) Ajouter une propriété Année de construction (BuildYear) dans cette classe
        //QUESTION : Est-il nécessaire de re-déclarer les propriétés Latitude, Longitude, Name ? Pourquoi ?

        //TODO 19) Créer un constructeur qui accepte les paramètres suivants : Latitude, Longitude, Name, BuildYear
        // Attention, ce constructeur doit réutiliser le constructeur parent avec le mot clé base()

        //TODO 20) Redéfinir la méthode toString pour qu'elle retourne une chaîne de caractère de la forme (NAME est un monument historique construit en BUILDYEAR)
        //où NAME et BUILDYEAR seront remplacés par les valeurs des propriétés correspondantes
    }
}
