using Microsoft.VisualStudio.TestTools.UnitTesting;
using JobBoard.Models;
using System;
using System.Collections.Generic;

namespace JobBoard.Tests
{
    [TestClass]
    public class JobOpeningTests : IDisposable
    {
        public void Dispose()
        {
            JobOpening.ClearAll();
        }
        // Test methods go here
        [TestMethod]
        public void JobOpeningConstructor_InstantiateJobOpeningClass_JobOpening()
        {
        JobOpening testJob = new JobOpening("programmer", "code good", "baabab@gmail.com");
        Assert.AreEqual(typeof(JobOpening), testJob.GetType());
        }

        [TestMethod]
        public void JobOpeningConstructor_NameFieldUpdates_String()
        {
            JobOpening testJob = new JobOpening("programmer", "code good", "baabab@gmail.com");
            Assert.AreEqual("programmer", testJob.Name);
        }

        [TestMethod]
        public void JobOpeningConstructor_DescriptionFieldUpdates_String()
        {
            JobOpening testJob = new JobOpening("programmer", "code good", "baabab@gmail.com");
            Assert.AreEqual("code good", testJob.Description);
        }

        [TestMethod]
        public void JobOpeningConstructor_EmailFieldUpdates_String()
        {
            JobOpening testJob = new JobOpening("programmer", "code good", "baabab@gmail.com");
            Assert.AreEqual("baabab@gmail.com", testJob.Email);
        }
        [TestMethod]
        public void GetAll_ReturnsEmptyList_JobList()
        {
            List<JobOpening> expectedList = new List<JobOpening> {};
            List<JobOpening> testList = JobOpening.GetAll();
            CollectionAssert.AreEqual(expectedList, testList);
        }

        [TestMethod]
        public void JobOpeningConstructor_AddJobOpeningToList_List()
        {
        JobOpening testJob = new JobOpening("programmer", "code good", "baabab@gmail.com");
        List<JobOpening> expectedList = JobOpening.GetAll();
        Assert.AreEqual( expectedList[0], testJob );
        }
    }
}