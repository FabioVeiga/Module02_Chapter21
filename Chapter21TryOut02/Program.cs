using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter21TryOut02
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            try
            {
                FileStream aFile = new FileStream("Log.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                //Read a first line
                line = sr.ReadLine();
                //Read data in line by line
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }catch(IOException e)
            {
                Console.WriteLine("An Exception has been thrown!");
                Console.WriteLine(e.ToString());
                return;
            }
            Console.ReadKey();
        }
    }
}
