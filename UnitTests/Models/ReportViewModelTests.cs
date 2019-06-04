﻿using System;
using HW1c.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            // Arrange       

            // Act   
            var result = new ReportViewModel();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Get_Default_Should_Pass()
        {
            // Arrange       
            var myTest = new ReportViewModel();

            // Act   
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_NumberOfUsers_Set_Default_Should_Pass()
        {
            // Arrange       
            var myTest = new ReportViewModel();
            var myUsers = 10;

            // Act   
            myTest.NumberOfUsers = myUsers;
            var result = myTest.NumberOfUsers;

            // Assert
            Assert.AreEqual(myUsers, result);
        }
    }
}
