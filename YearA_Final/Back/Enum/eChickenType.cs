using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YearA_Final.Back.Enum;

public enum eChickenType
{
    Choose,
    Breast,
    Wings,
    Thighs
}
public static class ChickenTypeExtantions
{
    public static string ToDisplayString(eChickenType type)
    {
        switch (type)
        {
            case eChickenType.Breast:
                return "Chicken Breast";
            case eChickenType.Wings:
                return "Chicken Wings";
            case eChickenType.Thighs:
                return "Chicken Thighs";
            default:
                return "";
        }
    }
}