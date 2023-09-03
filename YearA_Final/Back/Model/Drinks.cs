using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public abstract class Drinks : Category
    {
        public int Ml { get; set; }
        public  string Type { get; set; }

        protected Drinks(string name, string expiryDate, double price, int ml, string type)
            : base(name, expiryDate, price)
        {
            Ml = ml;            
            Type = type;
        }
        public override double CalcCalories()
        {
            return 0;
        }
    }
}
