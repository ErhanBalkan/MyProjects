using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullaniciOtomasyon
{
    internal class PersonManager : IPersonDal
    {
        public void AddPerson(Person person)
        {
            Person.Persons.Add(person);
            Console.WriteLine(person.Name + " başarıyla eklendi.");
        }

        public Person? GetPerson()
        {
            Console.WriteLine("Person ID : ");
            int personId = int.Parse(Console.ReadLine());
            foreach (Person person in Person.Persons)
            {
                if (person.Id == personId)
                {
                    return person;
                }                
            }
            return null;
        }

        public List<Person> GetPersonList()
        {
            return Person.Persons; 
        }

        public Person NewPerson()
        {
            Console.WriteLine("Eklemek istediğiniz kullanıcının ; ");
            Console.Write("ID : ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Adı : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Soyadı : ");
            string surName = Console.ReadLine();
            Console.WriteLine();
            Person person = new Person
                (
                    id = id,
                    name = name,
                    surName = surName
                );
            return person;
        }
    }
}
