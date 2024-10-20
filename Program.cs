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
            Dog pochi = new Dog();

            //最初の空腹状態を表示してみる
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungty());

            //pochiに餌を食べさせる
            pochi.Eat();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungty());

            //pochiに走らせる
            pochi.Run();
            Console.WriteLine("空腹状態 : {0}", pochi.IsHungty());

            //一時停止
            Console.ReadLine();
        }
       
    }
}
