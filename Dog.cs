using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1
{
    internal class Dog
    {
        private bool hungryState;


        public Dog() 
        {
            hungryState = true;
        }
        //食べる=>満腹になる
        public void Eat() 
        {
            Console.WriteLine("ぱくぱく");
            hungryState = false; //おなかはすいてない
        }
        //走る!!=>腹ペコ状態にする
        public void Run()
        {
            Console.WriteLine("わんわんわん");
            hungryState = true;　//おなかがすいた
        }

        public bool IsHungty()
        {
            return hungryState;
        }

    }
}
