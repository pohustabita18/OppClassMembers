﻿using OppClassMembers;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int IntiMaxLifespan = Person.MaxLifespanYears;

            Person p = new Person("2344");
            p.FirstName = "Florin";

            Console.WriteLine(Person.PopulationCount );
            Console.WriteLine(p.FirstName);
            Console.WriteLine(p.LastName);
            Console.WriteLine(p.Cnp);

           // Person.MaxLifespanYears
           //p.CNP="2344";
            //Person.PopulationCount = 1;
        }
    }
}