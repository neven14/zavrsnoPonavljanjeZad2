using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanjeZad2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ukSekundi, min, sec;
            string time;
            Console.Write("Unesi vrijeme u sekundama: ");
            ukSekundi = Convert.ToInt32(Console.ReadLine());

            sec = ukSekundi % 60;
            min = ukSekundi / 60;
            time = min + ":" + sec;
            Console.WriteLine(time);

            Console.ReadKey();
        }
    }
}
