using Tyuiu.NovikovaVA.Sprint2.Task7.V11.Lib;
namespace Tyuiu.NovikovaVA.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadeArea()
        {
            DataService ds  = new DataService();
            double x = -0.7;
            double y = -0.7;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}