using Tyuiu.MolchanovIV.Sprint6.Task0.V7.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task0.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.Calculate(3);
            double wait = 0.211;

            Assert.AreEqual(res, wait);

        }
    }
}
