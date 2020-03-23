using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFiveLab
{
    public class ComputerGame : Game
    {
        public string PEGI_RATING { get; set; }

        public ComputerGame(string name, decimal price, DateTime date, string pegi)
            : base(name, price, date)
        {
            PEGI_RATING = pegi;
        }
        public override string ToString()
        {
            return string.Format($"{ Name } - { Price } - {ReleaseDate}");
        }


        public decimal GetDiscountPrice()
        {
            return Price * .9m;
        }
        public override void UpdatePrice(decimal percentageIncrease)
        {
            Price *= (1 + percentageIncrease);
            Console.WriteLine("Updating the price");
        }
    }
