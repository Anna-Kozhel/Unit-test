using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnalaizerClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AnalaizerClassLibrary.Tests
{
    [TestClass()]
    public class AnalaizerClassTests
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "testData.xml", "Test", DataAccessMethod.Sequential)]
        
        [TestMethod()]
        public void Separate_StringToCollection()
        {
            //Arrange
            string incomingData = Convert.ToString(TestContext.DataRow["incomingData"]);
            IEnumerable<string> expected = Convert.ToString(TestContext.DataRow["expected"]).Split(' ').ToArray();
            //Actual
            IEnumerable<string> actual = AnalaizerClass.Separate(incomingData);
            //Assert
            CollectionAssert.AreEqual(expected.ToList(), actual.ToList());
        }
    }
}