using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using EmployeeProjects.DAO;
using EmployeeProjects.Models;

namespace EmployeeProjects.Tests.DAO
{
    [TestClass]
    public class TimesheetSqlDaoTests : BaseDaoTests
    {
        private static readonly Timesheet TIMESHEET_1 = new Timesheet(1, 1, 1, DateTime.Parse("2021-01-01"), 1.0M, true, "Timesheet 1");
        private static readonly Timesheet TIMESHEET_2 = new Timesheet(2, 1, 1, DateTime.Parse("2021-01-02"), 1.5M, true, "Timesheet 2");
        private static readonly Timesheet TIMESHEET_3 = new Timesheet(3, 2, 1, DateTime.Parse("2021-01-01"), 0.25M, true, "Timesheet 3");
        private static readonly Timesheet TIMESHEET_4 = new Timesheet(4, 2, 2, DateTime.Parse("2021-02-01"), 2.0M, false, "Timesheet 4");

        private TimesheetSqlDao dao;
        private Timesheet testTimesheet;


        [TestInitialize]
        public override void Setup()
        {
            dao = new TimesheetSqlDao(ConnectionString);
            testTimesheet = new Timesheet(0, 2, 1, DateTime.Parse("10/12/2021"), 3M, true, "Timesheet test");
            base.Setup();
        }

        [TestMethod]
        public void GetTimesheet_ReturnsCorrectTimesheetForId()
        {
            Timesheet timesheet = dao.GetTimesheet(1);

            AssertTimesheetsMatch(TIMESHEET_1, timesheet);
        }

        [TestMethod]
        public void GetTimesheet_ReturnsNullWhenIdNotFound()
        {
            Timesheet timesheet = dao.GetTimesheet(5);

            Assert.IsNull(timesheet);

        }

        [TestMethod]
        public void GetTimesheetsByEmployeeId_ReturnsListOfAllTimesheetsForEmployee()
        {
            IList<Timesheet> timesheetsByEmployeeId = dao.GetTimesheetsByEmployeeId(2);

            Assert.AreEqual(2, timesheetsByEmployeeId.Count);
            AssertTimesheetsMatch(TIMESHEET_3, timesheetsByEmployeeId[0]);
            AssertTimesheetsMatch(TIMESHEET_4, timesheetsByEmployeeId[1]);

        }

        [TestMethod]
        public void GetTimesheetsByProjectId_ReturnsListOfAllTimesheetsForProject()
        {
            IList<Timesheet> timesheetsByProjectId = dao.GetTimesheetsByProjectId(1);

            Assert.AreEqual(3, timesheetsByProjectId.Count);
            AssertTimesheetsMatch(TIMESHEET_1, timesheetsByProjectId[0]);
            AssertTimesheetsMatch(TIMESHEET_2, timesheetsByProjectId[1]);
            AssertTimesheetsMatch(TIMESHEET_3, timesheetsByProjectId[2]);
        }

        [TestMethod]
        public void CreateTimesheet_ReturnsTimesheetWithIdAndExpectedValues()
        {
            Timesheet createdTimesheet = dao.CreateTimesheet(testTimesheet);
            int createdTimesheetId = createdTimesheet.TimesheetId;

            Assert.IsTrue(createdTimesheetId > 0);

            testTimesheet.TimesheetId = createdTimesheetId;

            AssertTimesheetsMatch(testTimesheet, createdTimesheet);

        }

        [TestMethod]
        public void CreatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet createdTimessheet = dao.CreateTimesheet(testTimesheet);
            int newId = createdTimessheet.TimesheetId;
            Timesheet retrievedTimesheet = dao.GetTimesheet(newId);

            AssertTimesheetsMatch(createdTimessheet, retrievedTimesheet);

        }

        [TestMethod]
        public void UpdatedTimesheetHasExpectedValuesWhenRetrieved()
        {
            Timesheet timesheetToUpdate = dao.GetTimesheet(2);
            timesheetToUpdate.IsBillable = false;
            timesheetToUpdate.HoursWorked = 66;
            timesheetToUpdate.Description = "UPDATE";

            dao.UpdateTimesheet(timesheetToUpdate);
            Timesheet updatedTimesheet = dao.GetTimesheet(2);

            AssertTimesheetsMatch(timesheetToUpdate, updatedTimesheet);

        }

        [TestMethod]
        public void DeletedTimesheetCantBeRetrieved()
        {
            dao.DeleteTimesheet(1);
            Timesheet deletedTimesheet = dao.GetTimesheet(1);
            Assert.IsNull(deletedTimesheet);
        }

        [TestMethod]
        public void GetBillableHours_ReturnsCorrectTotal()
        {
            decimal billableHours = dao.GetBillableHours(1, 1);

            Assert.AreEqual(2.5M, billableHours);

            decimal billableHoursWithUnbillable = dao.GetBillableHours(2, 2);

            Assert.AreEqual(0, billableHoursWithUnbillable);
        }

        private void AssertTimesheetsMatch(Timesheet expected, Timesheet actual)
        {
            Assert.AreEqual(expected.TimesheetId, actual.TimesheetId);
            Assert.AreEqual(expected.EmployeeId, actual.EmployeeId);
            Assert.AreEqual(expected.ProjectId, actual.ProjectId);
            Assert.AreEqual(expected.DateWorked, actual.DateWorked);
            Assert.AreEqual(expected.HoursWorked, actual.HoursWorked);
            Assert.AreEqual(expected.IsBillable, actual.IsBillable);
            Assert.AreEqual(expected.Description, actual.Description);
        }
    }
}
