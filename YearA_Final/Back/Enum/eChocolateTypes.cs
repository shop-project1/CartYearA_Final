using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using YearA_Final.Back.Model;

namespace YearA_Final.Back.Enum
{
    public enum eChocolateTypes
    {
        None,
        WhiteChocolate,
        MilkChocolate,
        DarkChocolate
    }

    public static class ChocolateTypeExtantions
    {
        public static string ToDisplayString(eChocolateTypes type)
        {
            switch (type)
            {
                case eChocolateTypes.WhiteChocolate:
                    return "White Chocolate";
                    break;
                case eChocolateTypes.MilkChocolate:
                    return "Milk Chocolate";
                    break;
                case eChocolateTypes.DarkChocolate:
                    return "Dark Chocolate";
                    break;
                default:
                    return "";
                    break;

            }
        }


    }


}
