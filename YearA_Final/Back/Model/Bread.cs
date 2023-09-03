using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public class Bread : Food
    {
        public int BreadType { get; set; }

        public Bread(string name, string expiryDate, double price, int gram, int breadType)
            : base(name, expiryDate, price, gram)
        {
            BreadType = breadType;
        }

        public override double CalcCalories()
        {
            
            if (this.BreadType == 1)      // Black bread
            {
                return  this.Gram * 2.98;
            }
            else if (this.BreadType == 2) // rye
            {
                return  this.Gram * 2.59;
            }
            else                         // whole wheat
            {
                return  this.Gram * 2.47;
            }

        }
    }
}

