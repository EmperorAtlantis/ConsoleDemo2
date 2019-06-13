using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo2
{
    class Program
    {
        delegate string GetAString();
        static Func<string> getString;
        public static int Change(ref int a)
        {
            return a += 7;
        }
        static void Main(string[] args)
        {
            //int a = 0;
            //GetAString aString = new GetAString(a.ToString);
            //getString = new Func<string>(a.ToString);
            //Console.WriteLine(Change(ref a));
            //Console.WriteLine(aString());
            //Console.WriteLine(getString());

            Person person = new Person();
            person.Run();
            Console.Read();
        }


    }

}
