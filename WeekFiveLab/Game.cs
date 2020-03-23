using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekFiveLab
{
    public abstract class Game
    {

        #region properties 
        //public string Name{get;set;}

        private readonly string _name;
        // when a property is read-only, you can only assign it in the constructor
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public decimal Price { get; set; }
        public DateTime ReleaseDate { get; set; }
        #endregion properties 

        #region constructors
        public Game(string name, decimal price, DateTime releasedate)
        {
            _name = name;
            Price = price;
            ReleaseDate = releasedate;
        }

        public Game(string name, decimal price)
            : this(name, price, DateTime.Now)
        {

        }

        public Game() : this("", 0)
        {

        }

        public abstract void UpdatePrice(decimal percentageIncrease);
        public override string ToString()
        {
            return string.Format($"{ Name } - { Price } - {ReleaseDate}");
        }


        #endregion constructors
    }

}

