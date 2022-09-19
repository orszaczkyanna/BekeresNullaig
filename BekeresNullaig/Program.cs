using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BekeresNullaig
{
    class Program
    {
        //Addig kér be egész számokat, amíg nullát nem kap. Ekkor kiírja, hogy „elég” és megáll.
        static void Main(string[] args)
        {
            EgeszSzamKeres();
            Console.ReadKey();
        }
        private static void EgeszSzamKeres()
        {
            string beMenetStr;
            int beMenetInt;

            do
            {

                Console.WriteLine("Adj meg egész számokat!");
                beMenetStr = Console.ReadLine();
                if (!int.TryParse(beMenetStr, out beMenetInt))
                {
                    Console.WriteLine("Nem egész számot adtál meg!\n");
                }

            } while (beMenetStr != "0");
            Console.WriteLine("Elég");
        }
    }
}
