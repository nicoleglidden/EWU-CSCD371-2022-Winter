﻿namespace Lecture1
{
    public class Person
    {
        (string UserName, string Password)[] Credentials = new[] { 
            ("Inigo Montoya", "YouKilledMyF@ther!")
        }; 

        public bool Login(string userName, string password)
        {
            Credentials[0];
            return (userName, password) == Credentials[0];
        }
    }
}