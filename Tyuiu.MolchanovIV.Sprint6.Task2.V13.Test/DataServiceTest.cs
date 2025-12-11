using Tyuiu.MolchanovIV.Sprint6.Task2.V13;
using Tyuiu.MolchanovIV.Sprint6.Task2.V13.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            var res = ds.GetMassFunction(-5, 5);

            double[] wait = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
