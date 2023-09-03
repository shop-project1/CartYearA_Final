using YearA_Final.Back.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace YearA_Final.Back.Utils
{
    public class FileUtils
    {
        public static void SaveProductsToFile(BindingList<Category> products)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileInfo fileInfo = new FileInfo("products.bin");
            using (var binaryFile = fileInfo.Create())
            {
                binaryFormatter.Serialize(binaryFile, products);
                binaryFile.Flush();
            }
        }

        public static BindingList<Category> LoadProductsToFile()
        {
            BindingList<Category> products= new BindingList<Category>(); ;

            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileInfo fileInfo = new FileInfo("Products.txt");
                //NOTE: this code is for read in the text file Products.txt
                if (fileInfo.Exists)
                {
                    using (var binaryFile = fileInfo.OpenRead())
                    {
                        products = binaryFormatter.Deserialize(binaryFile) as BindingList<Category>;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            return products;
        }
    }
}
