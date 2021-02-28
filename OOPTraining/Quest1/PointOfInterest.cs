namespace OOPTraining.Quest1
{
    public class PointOfInterest
    {

        /* TODO 1) Modifier cette classe pour qu'elle contienne les propriétés suivantes : 
         * - une latitude (nombre à virgule)
         * - une longitude (nombre à virgule), 
         * - un nom (chaîne de caractères)
         */

        /* TODO 2) Ajouter une variable statique pour stocker le pattern d'une URL googlemap  : https://www.google.com/maps/place/{0}/@{1},{2},15z/ */


        /* TODO 3) Ajouter ensuite 2 constructeurs :
        * - un qui ne prend aucun paramètre. Les valeurs par défaut qui seront affectées aux propriétés sont les suivantes : 
        *          - Nom : Bordeaux Ynov Campus
        *          - Latitude : 44.854186
        *          - Longitude : -0.5663056
        * - un qui prend en paramètre nom, latitude et longitude
        * 
        * TODO 4) A votre avis, pourquoi je ne pouvais pas écrire de test unitaire pour votre constucteur à 3 paramètres ?
        * TODO 5) Créer un test unitaire pour votre constructeur à 3 paramètres. qui respectera la logique suivante
        * - vous créez un objet PointOfInterest que vous affectez à une variable 'pyc' en utilisant votre constructeur à 3 paramètres auquel
        * vous passez les valeurs suivantes : "Paris Ynov Campus", 48.9016552, 2.2079985
        * - vous vérifiez ensuite que les propriétés Name, Latitude et Longitude sont bien égales aux valeurs passées en paramètres
        */

        //TODO 6) Modifier la méthode suivante pour qu'en utilisant les propriétés de l'objet, ainsi que le pattern google maps de la question 2, cette méthode
        //retourne une URL Google Maps comme celle-ci : https://www.google.com/maps/place/Bordeaux+Ynov+Campus/@44.854186,-0.5663056,15z/
        /// <summary>
        /// This methods returns the Google Maps Url for the current point of interest
        /// </summary>
        /// <returns>Google Maps URL (e.g. : https://www.google.com/maps/place/Bordeaux+Ynov+Campus/@44.854186,-0.5663056,15z/")</returns>
        public string GetGoogleMapsUrl()
        {
            return null;
        }

        //TODO 7) Créez un test unitaire supplémentaire sur le modèle de celui intitulé "GetGoogleMapsUrl_DefaultObject_CorrectBYCMapsUrl" pour le campus de Paris

        //TODO 8) Modifier le corps de la méthode ci-dessous pour retourner une chaîne de la forme Nom-du-Point-d'interêt (Lat=XXXXXXXXX, Long=YYYYYYYYYY)
        //TODO 9) A quoi sert selon vous le mot clé "override" ?
        public override string ToString()
        {
            return "";
        }


        //TODO 10)Proposez une implémentation des méthodes suivantes pour retourner une distance en mètres à partir de 2 points d'intérêt
        //TODO 11)Trouvez comment compléter ces méthodes pour bénéficier de textes d'explication lors de l'autocomplétion de la méthode dans votre IDE
        //TODO 12) Ecrivez les tests unitaires pour ces 2 méthodes
        public double GetDistance(PointOfInterest other)
        {
            return 0;
        }

        public static double GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            return 0;
        }
    }
}
