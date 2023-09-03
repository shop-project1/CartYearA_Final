using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public class Chocolate : Food
    {
        public int ChocolateType { get; set; }
        public int FatProcetage { get; set; }

        public Chocolate(string name, string expiryDate, double price,
            int gram, int chocolateType, int fatProcetage)
            : base(name, expiryDate, price, gram)
        {
            ChocolateType = chocolateType;
            FatProcetage = fatProcetage;
        }       

        public override double CalcCalories()
        {

            if (this.ChocolateType == 1)      // Milk Chocolate
            {
                return this.Gram *this.FatProcetage * 2.98;
            }
            else if (this.ChocolateType == 2) // White Chocolate.
            {
                return this.Gram * this.FatProcetage * 2.59;
            }
            else                              //Dark Chocolate.
            {
                return this.Gram * this.FatProcetage * 2.47;
            }

        }
    }
}

