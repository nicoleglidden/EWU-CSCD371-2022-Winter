using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assignment
{
    public class SampleData : ISampleData, IEnumerable<IPerson>
    {
        // 1.
        public IEnumerable<string> CsvRows { get; private set; } = File.ReadAllLines("People.csv").Skip(1);

        // 2.
        public IEnumerable<string> GetUniqueSortedListOfStatesGivenCsvRows()
            => CsvRows.Select(x => x.Split(',')[6]).Distinct().OrderBy(x => x);

        // 3.
        public string GetAggregateSortedListOfStatesUsingCsvRows() => string.Join(",", GetUniqueSortedListOfStatesGivenCsvRows().ToArray());



        // 4.
        public IEnumerable<IPerson> People => CsvRows.Select(line =>
        {
            string[] lineParts = line.Split(',');
            IAddress address = new Address(lineParts[4], lineParts[5], lineParts[6], lineParts[7]);
            Person person = new Person(lineParts[1], lineParts[2], address, lineParts[3]);
            return person;
        }
        ).OrderBy(p => p.Address.State).ThenBy(p => p.Address.City).ThenBy(p => p.Address.Zip);


        // 5.
        public IEnumerable<(string FirstName, string LastName)> FilterByEmailAddress(
            Predicate<string> filter) => People.Where(l => filter(l.EmailAddress)).Select(l => (l.FirstName, l.LastName));

        // 6.
        public string GetAggregateListOfStatesGivenPeopleCollection(
            IEnumerable<IPerson> people) => people.Select(p => p.Address.State).Distinct().Aggregate((stateString, next) => next + ',' + stateString);


        public IEnumerator<IPerson> GetEnumerator()
        {
            return People.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public SampleData()
        {

        }

        public SampleData(IEnumerable<string> spokane)
        {
            CsvRows = spokane;
        }
    }

    
}
