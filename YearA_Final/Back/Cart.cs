using YearA_Final.Back.Enum;
using YearA_Final.Back.Model;
using YearA_Final.Back.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back
{
    public class Cart
    {
        public static BindingList<Category> products { get; set; }

        static Cart()
        {
            products = FileUtils.LoadProductsToFile();
        }

        public static void AddProducts(Category product)
        {
            products.Add(product);
        }

        public static void RemoveProducts(Category product)
        {
            products.Remove(product);
        }

        public static BindingList<T> GetProductsByType<T>() where T : Category
        {
            BindingList<T> requestedProducts = new BindingList<T>();
            foreach (var product in products)
            {
                if (product is T)
                {
                    requestedProducts.Add(product as T);
                }
            }
            return requestedProducts;
        }

        public static void SaveProducts()
        {
            FileUtils.SaveProductsToFile(products);
        }
    }
}