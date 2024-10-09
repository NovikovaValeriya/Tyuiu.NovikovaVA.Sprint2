using Tyuiu.NovikovaVA.Sprint2.Task5.V15.Lib;
namespace Tyuiu.NovikovaVA.Sprint2.Task5.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int k;
            k = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            k = Convert.ToInt32(Console.ReadLine());
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("K = " + k);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.FindDayName(k);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
