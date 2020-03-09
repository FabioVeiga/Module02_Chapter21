using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chapter21TryOut01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                FileStream aFile = new FileStream("Log.txt", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(aFile);

                bool truth = true;
                //Write data to file
                sw.WriteLine("Hello to you");
                sw.WriteLine("It is now {0} and things are looking good", DateTime.Now.ToString());
                sw.Write("More than that");
                sw.Write("It's {0} that C# is fun.", truth);
                sw.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("An exception has been thrrow");
                Console.WriteLine(e.ToString());
                Console.ReadLine();
                return;
            }
        }
    }
}
