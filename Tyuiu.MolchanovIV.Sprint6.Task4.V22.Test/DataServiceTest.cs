using Tyuiu.MolchanovIV.Sprint6.Task4.V22.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task4.V22.Test
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
