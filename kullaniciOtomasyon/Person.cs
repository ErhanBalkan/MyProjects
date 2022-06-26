using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullaniciOtomasyon
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public Person(int id, string name, string surName)
        {
            Id = id;
            Name = name;
            SurName = surName;
        }

        static public List<Person> Persons = new List<Person>();
    }
}
