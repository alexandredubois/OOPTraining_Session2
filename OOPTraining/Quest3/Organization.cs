using OOPTraining.Quest1;
using OOPTraining.Quest2;
using System.Collections.Generic;

namespace OOPTraining.Quest3
{
    public class Organization
    {
        public string Name { get; set; }

        public PointOfInterest HeadQuarter { get; set; }

        public List<Campus> CampusList { get; set; }

        public Organization(string name, PointOfInterest headQuarter, List<Campus> campusList)
        {
            Name = name;
            HeadQuarter = headQuarter;
            CampusList = campusList;
        }
    }
}
