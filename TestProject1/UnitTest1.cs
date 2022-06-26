using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task11;
using NUnit.Framework;

namespace Task11UnitTests
{
    [TestFixture]
    class UnitTests
    {
        private List<string> testPlan = new List<string> { "Madrid", "Barcelona", "Valencia" };

        [Test]
        public void ConstructorTest()
        {
            var tour = CreateTestTour();

            Assert.AreEqual("Spanish tour", tour.Name);
            Assert.AreEqual(35149, tour.Code);
            Assert.AreEqual(testPlan, tour.Plan);
            Assert.AreEqual(TransportType.train, tour.Transport);
            Assert.AreEqual(20, tour.Duration);
        }

        [Test]
        public void ToString_Tour_NameSpaceCode()
        {
            var tour = CreateTestTour();
            Assert.AreEqual("Spanish tour 35149", tour.ToString());
        }

        private Tour CreateTestTour()
        {
            return new Tour("Spanish tour", 35149, testPlan, TransportType.train, 20);
        }
    }
}
