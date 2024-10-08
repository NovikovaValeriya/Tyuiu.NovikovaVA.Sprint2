using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.NovikovaVA.Sprint2.Task1.V20.Lib
{
    public class DataService : ISprint2Task1V20
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];
            res[0] = (b == a) | (c < d);
            res[1] = (b > a) & (c < d);
            res[2]=  (a == b) || (c < d*2);
            res[3] = (a != c) && (c == d + 439);
            res[4] = (!(res[0]));
            res[5] = (a < b) ^ (c < d);

            return res;
        }
    }
}
