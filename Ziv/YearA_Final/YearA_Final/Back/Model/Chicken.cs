using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public class Chicken : Food
    {
        public string ChickenType { get; set; }

        public Chicken(string name, string expiryDate, double price, int gram, string chickenType)
            : base(name, expiryDate, price, gram)
        {
            ChickenType = chickenType;
            Gram = gram;
        }

        //public override double CalcCalories()
        //{
        //}
        public override double CalcCalories()
        {

            if (this.ChickenType == eChickenType.Breast.ToString())     
            {
                return this.Gram * 1.65;
            }
            else if (this.ChickenType.ToString() == eChickenType.Thighs.ToString()) 
            {
                return this.Gram * 1.77;
            }
            else                       
            {
                return this.Gram * 2.03;
            }

        }
    }
}
