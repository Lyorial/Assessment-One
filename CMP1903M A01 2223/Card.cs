using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Random;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        public int Value { get; set; }
        public int Suit { get; set; }


        public async Values SetValue()
        {
            get Value = 0;

            Values_Random Values_Random = new Values_Random(1:13);
            Values_Random = Value;
            set Value = Values_Random()
            Console.WriteLine(Value);


        }

        public async Suits SetValue()
        {
            get Suit = 0;
            Suits_Random Suits_Random = new Suits_Random(1:4);
            Suits_Random = Suit;
            set Suit = Suits_Random()
            Console.WriteLine(Suit);
        }

    }
}
