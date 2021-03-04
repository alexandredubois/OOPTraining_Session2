using System;
using System.Globalization;

namespace OOPTraining.Quest1
{
    public enum PoiType
    {
        None,
        Campus,
        Monument
    }

    public class PointOfInterest
    {

        /* TODO 1) Modifier cette classe pour qu'elle contienne les propriétés suivantes : 
         * - une latitude (nombre à virgule)
         * - une longitude (nombre à virgule), 
         * - un nom (chaîne de caractères)
         */

        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public PoiType Nature { get; set; }

        /* TODO 2) Ajouter une variable statique pour stocker le pattern d'une URL googlemap  : https://www.google.com/maps/place/{0}/@{1},{2},15z/ */
        public static string GoogleMapUrlPattern = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        /* TODO 3) Ajouter ensuite 2 constructeurs :
        * - un qui ne prend aucun paramètre. Les valeurs par défaut qui seront affectées aux propriétés sont les suivantes : 
        *          - Nom : Bordeaux Ynov Campus
        *          - Latitude : 44.854186
        *          - Longitude : -0.5663056
        * - un qui prend en paramètre nom, latitude et longitude
        */

        public PointOfInterest()
        {
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }
        
        /// <summary>
        /// Constructs a new PointOfInterest objet
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="latitude">Latitude</param>
        /// <param name="longitude">Longitude</param>
        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        /* TODO 4) A votre avis, pourquoi je ne pouvais pas écrire de test unitaire pour votre constucteur à 3 paramètres ?
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
            return string.Format(CultureInfo.InvariantCulture, GoogleMapUrlPattern, Name.Replace(' ', '+'), Latitude, Longitude);
        }

        //TODO 7) Créez un test unitaire supplémentaire sur le modèle de celui intitulé "GetGoogleMapsUrl_DefaultObject_CorrectBYCMapsUrl" pour le campus de Paris

        //TODO 8) Modifier le corps de la méthode ci-dessous pour retourner une chaîne de la forme Nom-du-Point-d'interêt (Lat=XXXXXXXXX, Long=YYYYYYYYYY)
        //TODO 9) A quoi sert selon vous le mot clé "override" ?
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0} (Lat={1}, Long={2})", Name, Latitude, Longitude);
        }


        //TODO 10) Proposez une implémentation des méthodes suivantes pour retourner une distance en mètres à partir de 2 points d'intérêt
        //TODO 11) Trouvez comment compléter ces méthodes pour bénéficier de textes d'explication lors de l'autocomplétion de la méthode dans votre IDE
        //TODO 12) Ecrivez les tests unitaires pour ces 2 méthodes
        public double GetDistance(PointOfInterest other)
        {
            return GetDistance(Longitude, Latitude, other.Longitude, other.Latitude);
        }

        public static double GetDistance(PointOfInterest p1, PointOfInterest p2)
        {
            return GetDistance(p1.Longitude, p1.Latitude, p2.Longitude, p2.Latitude);
        }

        private static double GetDistance(double longitude, double latitude, double otherLongitude, double otherLatitude)
        {
            var d1 = latitude * (Math.PI / 180.0);
            var num1 = longitude * (Math.PI / 180.0);
            var d2 = otherLatitude * (Math.PI / 180.0);
            var num2 = otherLongitude * (Math.PI / 180.0) - num1;
            var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) + Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);

            return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }


    }
}
