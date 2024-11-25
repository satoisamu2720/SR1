using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(3);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("---");

            Console.ReadLine();

            numbers.Add(7);
            numbers.Add(2);
            numbers.Add(1);
            numbers.Add(5);

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("---");

            Console.ReadLine();

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("---");

            Console.ReadLine();
        }
    }
}
