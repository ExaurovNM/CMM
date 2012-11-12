using System;

namespace Common
{
    public class ConsoleProvider
    {
        public int ReadeInt()
        {
            string line = Console.ReadLine();
            return Int32.Parse(line);
        }

        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }
    }
}
