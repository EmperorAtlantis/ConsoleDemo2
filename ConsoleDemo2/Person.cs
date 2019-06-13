using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleDemo2
{

    public class Person
    {
        //delegate void CheckHungryEHandler();
        public int HungryVlue { get; set; }

        
        public Person()
        {
            HungryVlue = 100;
            CheckHungry += HungryListener;
            Console.WriteLine(HungryVlue);
            
        }

        public void Run()
        {
            while (HungryVlue > 15)
            {
                CheckHungryToEat();
                Thread.Sleep(100);
                HungryVlue -= 5;
                Console.WriteLine(HungryVlue);
            }

        }

        public void CheckHungryToEat()
        {
            if (HungryVlue <= 20)
            {
                CheckHungry(this,new CheckHungryEventArgs());
            }
        }

        public void Eat()
        {
            HungryVlue = 100;
            Console.WriteLine(HungryVlue);
        }

        private event EventHandler<CheckHungryEventArgs> CheckHungry;
        public void HungryListener(object sender , CheckHungryEventArgs e)
        {
            
            Console.WriteLine("饿了吃饭!");
            Eat();
            
        }
    }
}
