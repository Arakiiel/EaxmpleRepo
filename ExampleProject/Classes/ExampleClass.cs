using System.Collections.Generic;

namespace ExampleProject.Classes
{
    class FullName
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public FullName(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public string ReturnFullName()
        {
            return FirstName +" "+ MiddleName+ " " + LastName;

            //return null;
            //return "adsfa";
            return null;
        }
    }

    class ExampleClass
    {
        public List<FullName> Names { get; set; }

        public ExampleClass()
        {
            Names = new List<FullName>();
        }

        public void InitialiseNames()
        {
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
            Names.Add(new FullName("name1", "name2", "name3"));
        }

        public List<FullName> ReturnNames()
        {
            foreach (FullName name in Names)
            {
                name.LastName = AlterName(name.LastName);
            }
            return Names;
        }

        public string AlterName(string name)
        {
            return name + Utils.RandomStringGenerator.RandomString(4);
        }

        public void AlterNames()
        {
            foreach(FullName name in Names)
            {
                name.LastName = AlterName(name.LastName);
            }
        }

        public void example()
        {
            string temp = Utils.RandomStringGenerator.RandomString(12);
            var change = "random change";
        }
    }
}
