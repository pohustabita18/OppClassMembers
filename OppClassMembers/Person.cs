namespace OppClassMembers
{
    internal class Person
    {
       private string _firstName = "John";

        private string _lastName = "Doe";

        // readonly field can be modified from the initialization expression (#1)
        private readonly string _cnp = "1234";

        private static int _populationCount = 0;

        public static readonly int MaxLifespanYears = IntiMaxLifespan();

        // acesta este un constructor
        public Person(string cnp)
        {
            //readonly poate fii modificat from the constructor(#2)
            _cnp = cnp;

            // each time a new person get created, populationCount is incremented
            Person._populationCount++;
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _firstName = value;
                }
                else
                {
                    //or raise error
                    _firstName = string.Empty;
                }
            }
        }



        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public string Cnp
        {
            get { return _cnp; }
        }

        public static int PopulationCount
        {
            get { return Person._populationCount; }
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
