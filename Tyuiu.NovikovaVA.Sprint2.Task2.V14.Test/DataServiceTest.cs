using Tyuiu.NovikovaVA.Sprint2.Task2.V14.Lib;
namespace Tyuiu.NovikovaVA.Sprint2.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds = new DataService();
            int x = 12;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}