﻿using System;
using System.Collections.Generic;
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

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            // Arrange       
            var myTest = new ReportViewModel();

            // Act   
            var result = myTest.LogViewModel;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            // Arrange       
            var myTest = new ReportViewModel();
            var myList = new List<LogModel>();
            myList.Add(new LogModel { PhoneID = "Phone" });
            var myLogViewModel = new LogViewModel
            {
                LogList = myList
            };

            // Act 
            myTest.LogViewModel = myLogViewModel;
            var result = myTest.LogViewModel;

            // Assert
            Assert.AreEqual("Phone", result.LogList[0].PhoneID);
        }
    }
}
