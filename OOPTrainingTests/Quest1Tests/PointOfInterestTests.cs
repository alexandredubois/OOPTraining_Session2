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
        public void ToString_DefaultObject_CorrectToStringFormat()
        {
            var byc = new PointOfInterest();
            Assert.AreEqual("Bordeaux Ynov Campus (Lat=44.854186, Long=-0.5663056)", byc.ToString());
        }

    }
}
