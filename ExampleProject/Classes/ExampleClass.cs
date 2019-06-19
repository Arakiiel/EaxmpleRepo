using System.Collections.Generic;
using System.Threading.Tasks;
#nullable enable

namespace ExampleProject.Classes
{
    struct Name
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName => FirstName + LastName;

        public readonly string ReturnFullName() => FullName;

        //public readonly string ModifyFullName()
        //{
        //    FirstName = FirstName + "asdf";
        //    return FirstName;
        //}
    }

    interface IFullName
    {
        string FirstName { get; set; }
        string MiddleName { get; set; }
        string LastName { get; set; }

        string ReturnFullName();
        string ReturnFullName(string randomString)
        {
            return FirstName + " " + LastName + " " + randomString;
        }
    }


    class FullName : IFullName
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public FullName(string firstName, string middleName, string lastName)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
        }

        public void Deconstruct(out string firstName, out string middleName, out string lastName)
        {
            firstName = FirstName;
            middleName = MiddleName;
            lastName = LastName;
        }

        public string ReturnFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;

            //return null;
            //return "adsfa";
            return null;
        }
    }

    class ExampleClass
    {
        public List<FullName> Names { get; set; }
        public string[] NameArray { get; set; }


        public ExampleClass()
        {
            Names = new List<FullName>();
            NameArray = new string[5] { "name 1", "name 2", "name 3", "name 4", "name 5" };
        }



        public void InitialiseNames()
        {
            Names.Add(new FullName("first name 1", "middle name 1", "last name 1"));
            Names.Add(new FullName("first name 2", "middle name 2", "last name 2"));
            Names.Add(new FullName("first name 3", "middle name 3", "last name 3"));
            Names.Add(new FullName("first name 4", "middle name 4", "last name 4"));
            Names.Add(new FullName("first name 5", "middle name 5", "last name 5"));
            Names.Add(new FullName("first name 6", "middle name 6", "last name 6"));
            Names.Add(new FullName("first name 7", "middle name 7", "last name 7"));
            Names.Add(new FullName("first name 8", "middle name 8", "last name 8"));

        }

        public List<FullName> ReturnNames()
        {
            foreach (FullName name in Names)
            {
                if (name.MiddleName != null)
                {
                    name.MiddleName = AlterName(name.MiddleName);
                }

                name.LastName = AlterName(name.LastName);
            }
            return Names;
        }

        //async example
        public async IAsyncEnumerable<string> AsyncExample()
        {
            foreach (string s in this.NameArray)
            {
                await Task.Delay(1000);
                yield return s;
            }
        }

        public string AlterName(string name)
        {
            return name + Utils.RandomStringGenerator.RandomString(4);
        }

        public void AlterNames()
        {
            foreach (FullName name in Names)
            {
                name.LastName = AlterName(name.LastName);
            }
        }

        public void example()
        {
            string temp = Utils.RandomStringGenerator.RandomString(12);
            var change = "random change";
        }

        //property pattern

        public string PropertyPatternExample(FullName fullName, string additionalString) =>
            fullName switch
            {
                { FirstName: "first name 1" } => "First name found " + additionalString,
                { FirstName: "first name 2" } => "Second name found " + additionalString,
                { FirstName: "first name 3" } => "Third name found " + additionalString,
                _ => "None found"
            };



    }
}
