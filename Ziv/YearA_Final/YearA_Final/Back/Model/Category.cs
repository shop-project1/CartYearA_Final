using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Model
{
    [Serializable]
    public abstract class Category
    {
        public string Name { get; set; }
        public string ExpiryDate { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Cool { get; set; } = false;

        protected Category(string name, string expiryDate, double price)
        {
            Name = name;
            ExpiryDate = expiryDate;
            Price = price;
        }
        virtual public double CalcCalories()
        {
            return 0 ;
        }
    }
}
