namespace DataAccesTest
{
    #region Usings
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Server.DataAccess;
    #endregion


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            const string quickPath = @"C:\S kode mappe\SimpleClientServer\Server.Services\bin\Debug\DateTest.txt";
            const string DateFormat = "yyyy.MM.dd";
            string message = "Test log message 2";
            string Space = " ";
            

            string actualRes;
            string expectedRes = DateTime.Today.ToString(DateFormat) + Space + message;
            //Act
            Logger.Log(message);
            //Assert
            using(System.IO.StreamReader sr = new System.IO.StreamReader(quickPath))
            {
                actualRes = sr.ReadToEnd();
                Assert.AreEqual(expectedRes, actualRes);
            }

        }
    }
}
