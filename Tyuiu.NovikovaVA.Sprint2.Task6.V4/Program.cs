using Tyuiu.NovikovaVA.Sprint2.Task6.V4.Lib;
namespace Tyuiu.NovikovaVA.Sprint2.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Новикова В. А. | ИСТНб-24-1";
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                          *");
            Console.WriteLine("* Тема: Получение результата из switch                                                                               *");
            Console.WriteLine("* Задание #6                                                                                                         *");
            Console.WriteLine("* Вариант #4                                                                                                         *");
            Console.WriteLine("* Выполнил: Новикова Валерия Александровна | ИСТНб-24-1                                                              *");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                   *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine("Введите номер масти: ");
            int value = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((value < 1) || (value > 4))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = "Масть карты: " + ds.FindCardSuit(value);
            }
            Console.WriteLine("**********************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("**********************************************************************************************************************");

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
