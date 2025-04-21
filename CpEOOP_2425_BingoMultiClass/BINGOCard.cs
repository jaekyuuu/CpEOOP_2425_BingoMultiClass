using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CpEOOP_2425_BingoMultiClass
{
    internal class BINGOCard
    {
        private Number[,] _Card = new Number[5, 5];
        private MyList _nums = new MyList();

        public void Initialize()
        {
            _Card = new Number[5, 5];
            _nums = new MyList();

            for(int x = 1; x < 76; x++)
                _nums.AddToList(x);

            for (int x = 0; x < _Card.GetLength(0); x++)
            {
                for (int y = 0; y < _Card.GetLength(1); y++)
                {
                    _Card[x, y] = new Number();
                }
            }
        }

        public void GenerateCard()
        {
            _nums = new MyList();

            for (int x = 1; x < 76; x++)
                _nums.AddToList(x);

            for (int x = 0; x < _Card.GetLength(0); x++)
            {
                for (int y = 0; y < _Card.GetLength(1); y++)
                {
                    _Card[x, y].genNumber(y);
                    if (_nums.ValueContain(_Card[x, y].getNumber()))
                        _nums.RemoveValue(_Card[x, y].getNumber());
                    else
                        y--;
                }
            }
        }

        public void Display()
        {
            for(int x = 0; x < _Card.GetLength(0); x++)
            {
                for(int y = 0;  y < _Card.GetLength(1); y++)
                {
                    Console.Write($"{_Card[x,y].getNumber()}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
