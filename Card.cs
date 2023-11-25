using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardDemo
{
    public class Card
    {
        private string rank; // This is a field, which gives the abiity to the card calss to store and share the information
        private string suit;

        public Card(string aRank, string aSuit) // Constructor is used to initalize the fields
        {
            rank = aRank;
            suit = aSuit;
        }

        public void PrintDetails() // Method 
        {
            Console.WriteLine("{0} {1}", rank, suit);
        }

    }
}
