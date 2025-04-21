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
            BINGOCard[] cards = new BINGOCard[5];

            for(int x = 0; x < cards.Length; x++)
            {
                cards[x] = new BINGOCard();
                cards[x].Initialize();
                cards[x].GenerateCard();
                cards[x].Display();

                Console.WriteLine();
            }


            //BINGOCard bc1 = new BINGOCard();
            //bc1.Initialize();
            //bc1.GenerateCard();
            //bc1.Display();
        }
    }
}
