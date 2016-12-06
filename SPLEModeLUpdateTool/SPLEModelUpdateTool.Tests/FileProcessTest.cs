using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SPLEModeLUpdateTool.Tests
{
    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void Test_readFeature()
        {
            //Arrange
            string[] arr;
            arr = FileProcess.readFeature("feature_sample.txt");

            for (int j = 0; j < arr.Length; j++)
            {
                Console.WriteLine(arr[j]);
            }
            if (arr!=null){ Assert.IsFalse(false); }
            else { Assert.IsFalse(true); }


            //Act

            //Assert
        }
    }
}
