using System;
using BinaryPower.Logic;
using Common;

namespace BinaryPower
{
    class Program
    {
        static void Main(string[] args)
        {
            var powerer = new BinaryPowerer();
            var console = new ConsoleProvider();

            while (true)
            {
                console.WriteLine("Enter a base:");
                int baseValue = console.ReadeInt();
                console.WriteLine("Enter a index:");
                int index = console.ReadeInt();
                console.WriteLine("Enter a mod:");
                int mod = console.ReadeInt();
                
                try
                {
                    var result = powerer.Rize(baseValue, index, mod);
                    console.WriteLine(string.Format("{0}^{1} mod {2} = {3}", baseValue, index, mod, result));
                }
                catch (Exception e)
                {
                    console.WriteLine(e.Message);
                }
            }
        }
    }
}
