using System.Collections.Generic;

namespace ExampleProject.Classes
{
    class FullName
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public string ReturnFullName()
        {
            return FirstName + MiddleName + LastName;

            //return null;
            //return "adsfa";
            return null;
        }
    }

    class ExampleClass
    {
        public List<FullName> Names { get; set; }


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

        public void example()
        {
            string temp = Utils.RandomStringGenerator.RandomString(12);

        }
    }
}
