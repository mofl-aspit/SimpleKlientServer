﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Server.DataAccess;

namespace DataAccesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string message = "test log message";
            
            //Act
            Logger.Log(message);
            //Assert
            
        }
    }
}
