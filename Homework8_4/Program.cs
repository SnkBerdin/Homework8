using System.IO;
using System.Xml.Linq;


namespace Homework8_4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите название улицы");
            string street = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            string HousNumb = Console.ReadLine();
            Console.WriteLine("Введите номер квартиры");
            string Flatnumb = Console.ReadLine();

            XElement myAdr = new XElement("Adress",
                new XElement("Street", street),
                new XElement("HouseNumber", HousNumb),
                new XElement("FlatNumber", Flatnumb));
            
            Console.WriteLine("Введите номер мобильного");
            string mobile = Console.ReadLine();
            Console.WriteLine("Введите номер домашнего телефона");
            string FlatPhone = Console.ReadLine();


            XElement myPhones = new XElement("Phones",
                new XElement("MobilePhone", mobile),
                new XElement("FlatPhone", FlatPhone));
            
            
            
            
            
            Console.WriteLine("Введите ФИО");
            XElement myPerson = new XElement("Person",
                new XAttribute("name", Console.ReadLine()),
                myAdr,
                myPhones);
            Console.WriteLine(myPerson);
            myPerson.Save("_person.xml");
            Console.ReadKey();
            






        }
    }
}
