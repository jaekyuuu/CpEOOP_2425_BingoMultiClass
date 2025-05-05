using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoMultiClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int BCcount = NumberChecker();
            FileManager fm = new FileManager();
            
            BINGOCard[] cards = new BINGOCard[BCcount];

            for(int x = 0; x < cards.Length; x++)
            {
                cards[x] = new BINGOCard();
                cards[x].Initialize();
                cards[x].GenerateCard();

                fm.FileWrite($"C:\\Users\\24-0147c\\Downloads\\BingoCard{x+1}.csv", cards[x].Stringify(), false);

                cards[x].Display();

                Console.WriteLine();
            }

        }


        static int NumberChecker()
        {
            int value;

            while (true)
            {
                Console.Write("Input Number of Bingo Cards:\t");
                string input = Console.ReadLine(); Console.WriteLine();

                if (int.TryParse(input, out value))
                {
                    if (value > 0)
                        return value;
                }

                else
                { Console.WriteLine("Invalid input! Please enter a valid number."); }
            }
        }


    }
}
