using System;

namespace Lecture;

public class Student : Person
{
   public Grade Grade { get; set; }

    public Student(string name):base(name)
    { 

    }
}