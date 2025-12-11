using Tyuiu.MolchanovIV.Sprint6.Task1.V8.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task1.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var res = ds.GetMassFunction(-5, 5);
            double[] wait = new double[11];
            wait = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(res, wait);

        }
    }
}
