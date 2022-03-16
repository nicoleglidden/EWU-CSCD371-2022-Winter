using System.Linq;
using System.Collections.Generic;
using System;

namespace Assignment
{
    public class Person : IPerson
    {
        public override bool Equals(Object? obj)
        {
            if (obj is null) return false;
            if (obj is not Person) return false;
            Person person = (Person) obj;

            return this.FirstName == person.FirstName && this.LastName == person.LastName && this.Address == person.Address && this.EmailAddress == person.EmailAddress;
            
        }
        public Person(string firstName, string lastName, IAddress address, string emailAddress)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            EmailAddress = emailAddress;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAddress Address { get;set; }
        public string EmailAddress { get; set; }

        public override int GetHashCode()
        {
            return (FirstName, LastName, Address, EmailAddress).GetHashCode();
        }
    }
}
