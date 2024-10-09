using Tyuiu.NovikovaVA.Sprint2.Task6.V4.Lib;
namespace Tyuiu.NovikovaVA.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardSuit()
        {
            var ds = new DataService();
            Assert.AreEqual("Пики", ds.FindCardSuit(1));
            Assert.AreEqual("Трефы", ds.FindCardSuit(2));
            Assert.AreEqual("Бубны", ds.FindCardSuit(3));
            Assert.AreEqual("Червы", ds.FindCardSuit(4));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(0);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindCardSuit(5);
            });
        }
    }
}