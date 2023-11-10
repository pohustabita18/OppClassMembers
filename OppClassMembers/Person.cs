﻿namespace OppClassMembers
{
    internal class Person
    {
        public string FirstName = "John";

        public string LastName = "Doe";

        // readonly field can be modified from the initialization expression (#1)
        public readonly string CNP = "1234";

        public static int PopulationCount = 0;

        public static readonly int MaxLifespanYears = IntiMaxLifespan();

        // acesta este un constructor
        public Person(string cnp)
        {
            //readonly poate fii modificat from the constructor(#2)
            CNP =cnp;

        }

        public void PrintPerson()
        {
           
        }

        public static void PrintPopulationCount()
        {

        }

        public static int IntiMaxLifespan()
        {
            Console.Write("Max Lifespan=");
            return Convert.ToInt32(Console.ReadLine());
        }

    }
}
