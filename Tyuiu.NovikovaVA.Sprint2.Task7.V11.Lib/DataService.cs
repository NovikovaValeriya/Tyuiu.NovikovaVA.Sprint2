using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NovikovaVA.Sprint2.Task7.V11.Lib
{
    public class DataService : ISprint2Task7V11
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1)
                if (y >= x)
                    return true;
                else if (x <= 0)
                    return true;
                else return false;
            else return false;
        }
    }
}
