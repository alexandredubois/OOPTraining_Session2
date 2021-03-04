using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPTraining.Quest1;

namespace OOPTrainingTests
{
    [TestClass]
    public class PointOfInterestTests
    {

        [TestMethod]
        public void PointOfInterestProperties_DefaultObject_HasLatitudeProperty()
        {
            var byc = new PointOfInterest();          
            Assert.IsTrue(byc.HasProperty("Latitude"));
        }

        [TestMethod]
        public void PointOfInterestProperties_DefaultObject_HasLongitudeProperty()
        {
            var byc = new PointOfInterest();
            Assert.IsTrue(byc.HasProperty("Longitude"));
        }

        [TestMethod]
        public void PointOfInterestProperties_DefaultObject_HasNameProperty()
        {
            var byc = new PointOfInterest();
            Assert.IsTrue(byc.HasProperty("Name"));
        }

        [TestMethod]
        public void GetGoogleMapsUrl_DefaultObject_CorrectBYCMapsUrl()
        {
            var byc = new PointOfInterest();
            Assert.AreEqual("https://www.google.com/maps/place/Bordeaux+Ynov+Campus/@44.854186,-0.5663056,15z/", byc.GetGoogleMapsUrl());
        }

        [TestMethod]
        public void GetGoogleMapsUrl_CustomPycObject_CorrectPYCMapsUrl()
        {
            PointOfInterest pyc = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            Assert.AreEqual("https://www.google.com/maps/place/Paris+Ynov+Campus/@48.9016552,2.2079985,15z/", pyc.GetGoogleMapsUrl());
        }

        /*Cr�er un test unitaire pour votre constructeur � 3 param�tres. qui respectera la logique suivante
        * - vous cr�ez un objet PointOfInterest que vous affectez � une variable 'pyc' en utilisant votre constructeur � 3 param�tres auquel
        * vous passez les valeurs suivantes : "Paris Ynov Campus", 48.9016552, 2.2079985
        * - vous v�rifiez ensuite que les propri�t�s Name, Latitude et Longitude sont bien �gales aux valeurs pass�es en param�tres
        */
        [TestMethod]
        public void PointOfInterestConstructor_ParisYnovCampus_CorrectPYCValues()
        {
            var pyc = new PointOfInterest("Paris Ynov Campus", 48.9016552, 2.2079985);
            Assert.AreEqual("Paris Ynov Campus", pyc.Name);
            Assert.AreEqual(48.9016552, pyc.Latitude);
            Assert.AreEqual(2.2079985, pyc.Longitude);
        }

        [TestMethod]
        public void ToString_DefaultObject_CorrectToStringFormat()
        {
            var byc = new PointOfInterest();
            Assert.AreEqual("Bordeaux Ynov Campus (Lat=44.854186, Long=-0.5663056)", byc.ToString());
        }

    }
}
