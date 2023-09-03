using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public abstract class Food : Category
    {
        public int Gram { get; set; }

        protected Food(string name, string expiryDate, double price, int gram)
            : base(name, expiryDate, price)
        {
            Gram = gram;
        }
        public override double CalcCalories()
        {
            return 0;
        }
    }
}