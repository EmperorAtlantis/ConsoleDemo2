using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo2
{
    public class CheckHungryEventArgs : EventArgs
    {
        public CheckHungryEventArgs()
        {
            Console.WriteLine("饥饿事件");
        }
    }
}
