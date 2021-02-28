using OOPTraining.Quest1;

namespace OOPTraining.Quest2
{
    public class HistoricalMonument : PointOfInterest
    {
        //TODO Faire hériter cette classe de la classe PointOfInterest
        //TODO Ajouter une propriété Année de construction (BuildYear) dans cette classe
        //QUESTION : Est-il nécessaire de re-déclarer les propriétés Latitude, Longitude, Name ? Pourquoi ?

        //TODO Créer un constructeur qui accepte les paramètres suivants : Latitude, Longitude, Name, BuildYear
        // Attention, ce constructeur doit réutiliser le constructeur parent avec le mot clé base()

        //TODO Redéfinir la méthode toString pour qu'elle retourne une chaîne de caractère de la forme (NAME est un monument historique construit en BUILDYEAR)
        //où NAME et BUILDYEAR seront remplacés par les valeurs des propriétés correspondantes
    }
}
