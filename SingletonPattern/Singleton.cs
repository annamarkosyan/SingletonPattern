using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=>new Singleton());

        public static Singleton GetInstanse
        {
            get
            {
                return instance.Value;
            } 
           
        }

        private Singleton()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
