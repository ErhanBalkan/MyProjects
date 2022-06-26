using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kullaniciOtomasyon
{
    internal interface IPersonDal
    {
        Person NewPerson();
        List<Person> GetPersonList();
        Person GetPerson();
        void AddPerson(Person person);
    }
}
