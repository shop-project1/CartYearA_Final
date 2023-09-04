using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public class Milk : Drinks
    {
        public double FatPercentage { get; set; }

        public Milk(string name, string expiryDate, double price, string type, double fatPercentage, int ml)
            : base(name, expiryDate, price, type, ml)
        {
            FatPercentage = fatPercentage;
        }
        public override double CalcCalories()
        {
            return  this.FatPercentage * 2 * 500;
        }
    }
}
