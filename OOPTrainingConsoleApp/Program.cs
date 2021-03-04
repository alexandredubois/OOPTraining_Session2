using OOPTraining.Quest1;
using OOPTraining.Quest2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOPTrainingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Campus pyc = new Campus("Paris Ynov Campus", 48.9016552, 2.2079985, 1500);
            Campus byc = new Campus("Bordeaux Ynov Campus", 44.854186, -0.5663056, 2500);
            Campus tyc = new Campus("Toulouse Ynov Campus", 3.6249209, 1.4314796, 1200);

            HistoricalMonument cailhau = new HistoricalMonument("Porte Cailhau", 44.8387609, -0.5684966, 1450);
            HistoricalMonument obelisque = new HistoricalMonument("Obélisque de Louxor", 48.865482, 2.3189306, 1836);
            HistoricalMonument musee = new HistoricalMonument("Musée des Augustins", 43.6007988, 1.4444903, 1795);

            List<PointOfInterest> poiList = new List<PointOfInterest>();

            poiList.Add(pyc);
            poiList.Add(byc);
            poiList.Add(tyc);
            poiList.Add(cailhau);
            poiList.Add(obelisque);
            poiList.Add(musee);

            DisplayPointOfInterestListWithEnum(poiList);

            DisplayPointOfInterestListWithoutEnum(poiList);

        }


        public static void DisplayPointOfInterestListWithEnum(List<PointOfInterest> poiList)
        {
            PointOfInterest me = new PointOfInterest("Alexandre sur le campus", 44.854186, -0.5663056);

            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine("| Type       | Nom                  |  Latitude  | Longitude  | Distance d'ici        |");
            Console.WriteLine("| __________ | ____________________ | __________ | ___________| _____________________ |");

            foreach (var poi in poiList)
            {
                Console.WriteLine("| {0} | {1} | {2} | {3} | {4} m|",
                    poi.Nature.ToString().PadRight(10, ' '),
                    poi.Name.PadRight(20, ' '),
                    poi.Latitude.ToString().PadRight(10, ' '),
                    poi.Longitude.ToString().PadRight(10, ' '),
                    poi.GetDistance(me).ToString().PadRight(20, ' '));
            }
        }

        public static void DisplayPointOfInterestListWithoutEnum(List<PointOfInterest> poiList)
        {
            PointOfInterest me = new PointOfInterest("Alexandre sur le campus", 44.854186, -0.5663056);

            Console.WriteLine("______________________________________________________________________________________");
            Console.WriteLine("| Type       | Nom                  |  Latitude  | Longitude  | Distance d'ici        |");
            Console.WriteLine("| __________ | ____________________ | __________ | ___________| _____________________ |");

            foreach (var poi in poiList)
            {
                Console.WriteLine("| {0} | {1} | {2} | {3} | {4} m|",
                    GetPoiNature(poi).PadRight(10, ' '),
                    poi.Name.PadRight(20, ' '),
                    poi.Latitude.ToString().PadRight(10, ' '),
                    poi.Longitude.ToString().PadRight(10, ' '),
                    poi.GetDistance(me).ToString().PadRight(20, ' '));
            }
        }

        private static string GetPoiNature(PointOfInterest poi)
        {
            if(poi is Campus)
            {
                return "Campus";
            }
            return "Monument";
        }

    }
}
