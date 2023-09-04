using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace YearA_Final.Back.Enum
    {
        public enum eBreadType
        {
            Choose,
            BlackBread,
            RyeBread,
            WholeWheatBread
        }

        public static class BreadTypeExtensions
        {
            public static string ToDisplayString(eBreadType type)
            {
                switch (type)
                {
                    case eBreadType.BlackBread:
                        return "Black Bread";
                    case eBreadType.RyeBread:
                        return "Rye Bread";
                    case eBreadType.WholeWheatBread:
                        return "Whole Wheat Bread";
                    default:
                        return ""; 
                }
            }
        }
    }

