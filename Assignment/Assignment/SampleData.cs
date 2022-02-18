using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData
    {
        // 1.
            
        public IEnumerable<string> CsvRows { get; private set; }

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
        {
            List<string> uniqueStates = CsvRows.Select
        } 
            

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows()
            => throw new NotImplementedException();

        // 4.
        public IEnumerable<IPerson> People()
        {
            List<IPerson> people;
            IEnumerable<string[]> CsvArrayRows = CsvRows.Select(l => l.Split(','));
            CsvRows.ForEach(l => l);
            CsvArrayRows.ForEach(row => new Person(row[1], row[2], row[3], row[4]));
            Person person = new Person();
        }

        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => throw new NotImplementedException();

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => throw new NotImplementedException();

        public SampleData()
        {
            string filename = "People.csv";
            List<string> lines = File.ReadAllLines(filename).Skip(1).ToList();
            CsvRows = lines;
            //lines.Select(l => l.Split(',')).ToArray();
        }
    }
}
