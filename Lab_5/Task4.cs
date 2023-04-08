using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Card
    {
        private int numcard;
        private int pincard;
        private int CVC;
        private string date;
        private int money;

        public void SetNumcard(int numcard)
        {
            this.numcard = numcard;
        }
        public int GetNumcard()
        {
            return numcard;
        }
        public void SetPincard(int pincard)
        {
            this.pincard = pincard;
        }
        public int GetPincard()
        {
            return pincard;
        }
        public void SetCVC(int CVC)
        {
            this.CVC = CVC;
        }
        public int GetCVC()
        {
            return CVC;
        }
        public void SetDate(string date)
        {
            this.date = date;
        }
        public string GetDate()
        {
            return date;
        }


        public static Card operator +(Card card, int amount)
        {
            card.money += amount;
            return card;
        }

        public static Card operator -(Card card, int amount)
        {
            card.money -= amount;
            return card;
        }

        public static bool operator ==(Card card1, Card card2)
        {
            if (ReferenceEquals(card1.CVC, card2.CVC))
            {
                return true;
            }

            if ((object)card1 == null || (object)card2 == null)
            {
                return false;
            }

            return card1.CVC == card2.CVC;
        }

        public static bool operator !=(Card card1, Card card2)
        {
            return !(card1 == card2);
        }

        public static bool operator <(Card card1, Card card2)
        {
            return card1.money < card2.money;
        }

        public static bool operator >(Card card1, Card card2)
        {
            return card1.money > card2.money;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Card card = obj as Card;

            if ((object)card == null)
            {
                return false;
            }

            return money == card.money;
        }

        public void ShowMoney()
        {
            Console.WriteLine($"\nMoney: {money}");
        }

        public void Input()
        {
            Console.Write("Enter card number: ");
            numcard = int.Parse(Console.ReadLine());

            Console.Write("Enter pin of card: ");
            pincard = int.Parse(Console.ReadLine());

            Console.Write("Enter CVC number of card: ");
            CVC = int.Parse(Console.ReadLine());

            Console.Write("Enter end date of card: ");
            date = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine($"\nCar number: {numcard}");
            Console.WriteLine($"Pin of card: {pincard}");
            Console.WriteLine($"CVC: {CVC}");
            Console.WriteLine($"End date: {date}");
        }
    }
}
