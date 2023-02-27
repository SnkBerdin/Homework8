using System.IO;
using System.Collections.Generic;


namespace Homework8_1
{
    class Program
    
    {
        static void AddList(List<int> num)
        {
            Random r = new Random();

            for (int i = 0; i < 100; i++)
            {
                num.Add(r.Next(0,100));
                
            }
        }

        static void ViewList(List<int> num)
        {
            for (int i = 0; i < num.Count; i++)
            {
                Console.Write($"{num[i]} ");
                
            }
            Console.WriteLine();
        }
        
        
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            AddList(numbers);

            

            ViewList(numbers);
            Console.ReadKey();
            numbers.RemoveAll(num => (num > 25) && (num < 50));
            ViewList(numbers);
            



        }
    }
}