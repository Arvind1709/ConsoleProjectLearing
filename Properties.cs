namespace ConsoleProjectLearing
{
    class Properties
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The first name must not be empty or null");
                }

                firstName = value;


            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The last name must not be empty or null");
                }

                lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0 || value > 150)
                {
                    throw new ArgumentException("The age must be between 1 and 150");
                }

                age = value;
            }
        }

        internal string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

    }

    // Person.cs

    class PropertiesPerson
    {
        private string firstName;
        private string lastName;
        private int age;


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }

    class Skill
    {
        public string Name { get; set; }
        public sbyte Rating { get; set; } = 1;
    }



    // Program.cs

    //var p1 = new Properties();

    //p1.FirstName = "Jane";
    //p1.LastName  = "Doe";
    //p1.Age = 25;

    //Console.WriteLine(p1.FullName);
}
