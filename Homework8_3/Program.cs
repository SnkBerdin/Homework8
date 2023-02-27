using System.IO;


namespace Homework8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> userNumbers = new HashSet<int>();
            int count = 0;
            while (true)
            {
                Console.WriteLine("Введите число (для выхода нажмите enter)");
                string userValue = Console.ReadLine();
                if (userValue=="")
                {
                    Console.WriteLine("Все числа: \n");
                    foreach (var numb in userNumbers)
                    {
                        
                        Console.Write($"{numb} ");
                    }
                    break;
                }
                userNumbers.Add(int.Parse(userValue));
                if (count==userNumbers.Count)
                {
                    Console.WriteLine("Число уже в списке");
                }
                else
                {
                    Console.WriteLine("Число успешно добавленно");
                    count = userNumbers.Count;
                }
                
                
            }
        }
    }
}