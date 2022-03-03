using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment.Tests
{
    [TestClass]
    public class SampleDataTests
    {
        [TestMethod]
        public void Test_CsvRows()
        {
            //Arrange
            string row2 = "1,Priscilla,Jenyns,pjenyns0@state.gov,7884 Corry Way,Helena,MT,70577";
            SampleData people = new();

            //Act
            var result = people.CsvRows.ToList();

            //Assert
            Assert.AreEqual(row2, result[0]);
        }
        
        [TestMethod]
        public void GetUniqueSortedListOfStatesGivenCsvRows_Hardcode_Test()
        {
            //Arrange
            //string addresses = "7884 Spokane Way,Spokane,WA,99205, 1234 Spokane Street,Spokane,WA,99201";

            //Act


            //Assert
        }

        [TestMethod]
        public void GetUniqueSortedListOfStatesGivenCsvRows_LINQ_Test()
        {
            //Arrange
            SampleData people = new();


            //Act
            var result = people.GetUniqueSortedListOfStatesGivenCsvRows().ToList();

            //Assert 
            Assert.AreEqual(result.Zip(result.Skip(1), (a, b) => new { a, b }).All(p => p.a.CompareTo(p.b)<0));
        }
    }
}
