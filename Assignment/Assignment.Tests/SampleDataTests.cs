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
            IEnumerable<string> listOfAddresses = new List<string> { "1,Priscilla,Jenyns,pjenyns0 @state.gov,7884 Spokane Way, Spokane,WA,99205", "2,Karin,Joder,kjoder1@quantcast.com,03594 Florence,Spokane,WA,99201" };
            SampleData people = new(listOfAddresses);


            //Act
            var result = people.GetUniqueSortedListOfStatesGivenCsvRows();

            //Assert
            Assert.AreEqual(result.Count(), 1);
            Assert.AreEqual(result.First(), "WA");
        }

        [TestMethod]
        public void GetUniqueSortedListOfStatesGivenCsvRows_LINQ_Test()
        {
            //Arrange
            SampleData people = new();


            //Act

            IEnumerable<string> statesList = people.GetUniqueSortedListOfStatesGivenCsvRows();
            IEnumerable<string> expectedStatesList = statesList.OrderBy(s => s);

            //Assert 

            Assert.AreEqual(expectedStatesList.Count(), statesList.Count());
            Assert.AreEqual(expectedStatesList.First(), statesList.First());
        }

        [TestMethod]

        public void GetAggregateSortedListOfStatesUsingCsvRows_Test()
        {
            //Arrange
            SampleData people = new();

            //Act
            string statesList = people.GetAggregateSortedListOfStatesUsingCsvRows();
            List<string> expectedStatesList = new List<string> { "AL", "AZ", "CA", "DC", "FL", "GA", "IN", "KS", "LA", "MD", "MN", "MO", "MT", "NC", "NE", "NH", "NV", "NY", "OR", "PA", "SC", "TN", "TX", "UT", "VA", "WA", "WV" };

            string combinedStates = string.Join(",", expectedStatesList);

            //Assert
            Assert.AreEqual(combinedStates.Count(), statesList.Count());
            Assert.AreEqual(combinedStates.First(), statesList.First());
            Assert.AreEqual(combinedStates.Last(), statesList.Last());
        }

        [TestMethod]

        public void ISampleData_People_Test()
        {
            //Arrange
            string firstName = "Priscilla";
            string lastName = "Jenyns";
            string email = "pjenyns0 @state.gov";
            string streetAddress = "7884 Spokane Way";
            string city = "Spokane";
            string state = "WA";
            string zip = "99205";
            string firstName2 = "Brian";
            string lastName2 = "Troll";
            string email2 = "brian.troll@underthebridge.com";
            string streetAddress2 = "1234 Brian Troll Way";
            string city2 = "San Diego";
            string state2 = "CA";
            string zip2 = "92103";
            IEnumerable<string> listOfAddresses = new List<string> { $"1,{firstName},{lastName},{email},{streetAddress},{city},{state},{zip}", $"2,{firstName2},{lastName2},{email2},{streetAddress2},{city2},{state2},{zip2}" };
            ISampleData sampleData = new SampleData(listOfAddresses);
            IAddress address = new Address(streetAddress, city, state, zip);
            IAddress address2 = new Address(streetAddress2, city2, state2, zip2);
            IPerson person = new Person(firstName, lastName, address, email);
            IPerson person2 = new Person(firstName2, lastName2, address2, email2);


            //Act
            IEnumerable<IPerson> humans = sampleData.People;
            IEnumerable<string> addresses = sampleData.CsvRows;


            //Assert
            Assert.AreEqual(person2, humans.First());
            Assert.AreEqual(person, humans.Last());
            Assert.IsNotNull(humans.First().Address);
        }
    }
}
