namespace kullaniciOtomasyon
{
    internal class Program
    {
        static void CizgiCek()
        {
            Console.WriteLine("--------------------");
        }
        static string Yonlendir()
        {
            CizgiCek();
            Console.WriteLine("Kullanıcı eklemek için - 1");
            Console.WriteLine("Kullanıcı çağırmak için - 2");
            Console.WriteLine("Kullanıcı listesini görmek için - 3");
            Console.WriteLine("Çıkış yapmak için - q");
            string result = Console.ReadLine();
            return result;
        }
        static void Main(string[] args)
        {
            PersonManager pm = new PersonManager();
            Console.WriteLine("Merhaba");
            while (true)
            {
                string cevap = Yonlendir();
                if (cevap == "1")
                {
                    Person person = pm.NewPerson();
                    pm.AddPerson(person);
                }else if (cevap == "2")
                {
                    Person p = pm.GetPerson();
                    if (p == null)
                    {
                        Console.WriteLine("Bu ID'ye sahip bir kullanıcı yok !");
                    }
                    else
                    {
                        Console.WriteLine(p.Id + " : " + p.Name + " " + p.SurName);
                    }
                }else if (cevap == "3")
                {
                    foreach (Person person in pm.GetPersonList())
                    {
                        Console.WriteLine(person.Id + " : " + person.Name + " " + person.SurName);
                    }
                }
                else if (cevap.ToLower() == "q")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı seçim !!!");
                }
            }
        }
    }
}