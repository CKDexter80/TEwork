using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using USCitiesAndParks.DAO;
using USCitiesAndParks.Models;

namespace USCitiesAndParks.Tests
{
    [TestClass]
    public class ParkSqlDaoTests : BaseDaoTests
    {
        private static readonly Park PARK_1 = new Park(1, "Park 1", DateTime.Parse("1800-01-02"), 100, true);
        private static readonly Park PARK_2 = new Park(2, "Park 2", DateTime.Parse("1900-12-31"), 200, false);
        private static readonly Park PARK_3 = new Park(3, "Park 3", DateTime.Parse("2000-06-15"), 300, false);
        Park testPark = new Park(0, "Test Park", DateTime.Now, 900, true);
        private ParkSqlDao dao;

        [TestInitialize]
        public override void Setup()
        {
            dao = new ParkSqlDao(ConnectionString);
            base.Setup();
        }

        [TestMethod]
        public void GetPark_ReturnsCorrectParkForId()
        {
            Park park = dao.GetPark(1);
            AssertParksMatch(PARK_1, park);

            Park park3 = dao.GetPark(3);
            AssertParksMatch(PARK_3, park3);
        }

        [TestMethod]
        public void GetPark_ReturnsNullWhenIdNotFound()
        {
            Park park = dao.GetPark(12);
            Assert.IsNull(park);
        }

        [TestMethod]
        public void GetParksByState_ReturnsAllParksForState()
        {
            IList<Park> parks =  dao.GetParksByState("AA");
            Assert.AreEqual(2, parks.Count);

            AssertParksMatch(PARK_1, parks[0]);
            AssertParksMatch(PARK_3, parks[1]);

        }

        [TestMethod]
        public void GetParksByState_ReturnsEmptyListForAbbreviationNotInDb()
        {
            IList<Park> parks = dao.GetParksByState("XX");
            Assert.AreEqual(0, parks.Count);
        }

        [TestMethod]
        public void CreatePark_ReturnsParkWithIdAndExpectedValues()
        {
           // Park testPark = new Park(0, "Test Park", DateTime.Now, 900, true);
            Park createdPark = dao.CreatePark(testPark);

            int newId = createdPark.ParkId;
            Assert.IsTrue(newId > 0);

            testPark.ParkId = newId;
            AssertParksMatch(testPark, createdPark);
        }

        [TestMethod]
        public void CreatedParkHasExpectedValuesWhenRetrieved()
        {
            //get park tests must pass first
            Park testPark = new Park(0, "Test Park", DateTime.Now, 900, true);
            Park createdPark = dao.CreatePark(testPark);

            int newId = createdPark.ParkId;

            Park park = dao.GetPark(newId);

            AssertParksMatch(park, createdPark);

        }

        [TestMethod]
        public void UpdatedParkHasExpectedValuesWhenRetrieved()
        {
            Park park = dao.GetPark(1);
            park.Area = 11;
            park.ParkName = "Changed";
            park.DateEstablished = DateTime.Now;
            park.HasCamping = !park.HasCamping;

            dao.UpdatePark(park);

            Park updated = dao.GetPark(1);

            AssertParksMatch(updated, park);
        }

        [TestMethod]
        public void DeletedParkCantBeRetrieved()
        {
            dao.DeletePark(1);

            Park deletedPark = dao.GetPark(1);

            Assert.IsNull(deletedPark);
        }

        [TestMethod]
        public void ParkAddedToStateIsInListOfParksByState()
        {

            IList<Park> parksInState = dao.GetParksByState("CC");
            int numberOfParks = parksInState.Count;
            dao.AddParkToState(1, "CC");
            IList<Park> parksInStateAfterAdd = dao.GetParksByState("CC");
            int numberOfParksAfterAdd = parksInStateAfterAdd.Count;
            Assert.AreEqual(numberOfParks + 1, numberOfParksAfterAdd);
        }

        [TestMethod]
        public void ParkRemovedFromStateIsNotInListOfParksByState()
        {
            Assert.Fail();
        }

        private void AssertParksMatch(Park expected, Park actual)
        {
            Assert.AreEqual(expected.ParkId, actual.ParkId);
            Assert.AreEqual(expected.ParkName, actual.ParkName);
            Assert.AreEqual(expected.DateEstablished.Date, actual.DateEstablished.Date);
            Assert.AreEqual(expected.Area, actual.Area);
            Assert.AreEqual(expected.HasCamping, actual.HasCamping);
        }
    }
}
