using System.IO;


namespace Homework8_2
{
    class Program
    {

        static void AddPhones(Dictionary<int, string> phones)
        {
            string name;
            int phone;
            while (true)
            {
                Console.WriteLine("Введите номер телефона");
                phone = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите Имя абонента");
                name = Console.ReadLine();
                phones.Add(phone,name);
                Console.WriteLine("Для выхода нажмите Enter ");
                if (string.IsNullOrEmpty(Console.ReadLine()))
                {
                    break;
                }


            }
            
        }

        static void SearchPhone(Dictionary<int, string> num)
        {
            int searchNumb;
            Console.WriteLine("Введите телефон для поиска владельца ");
            searchNumb = int.Parse(Console.ReadLine());
            string value = "";

            if (num.TryGetValue(searchNumb,out value))
            {
                Console.WriteLine($"Владелец номера {searchNumb} - {value}");
            }
            else
            {
                Console.WriteLine("нет совпадений");
            }
            
            
        }
        
        
        static void Main(string[] args)
        {
            Dictionary<int, string> noteBook = new Dictionary<int, string>();
            AddPhones(noteBook);

            foreach (var phone in noteBook)
            {
                Console.WriteLine($"Phone: {phone.Key} Name {phone.Value} ");
            }
            
            SearchPhone(noteBook);Console.ReadKey();
            
            
            
            
        }
    }
}
