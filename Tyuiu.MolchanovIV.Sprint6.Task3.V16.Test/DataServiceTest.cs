using Tyuiu.MolchanovIV.Sprint6.Task3.V16.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task3.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int[,] arrIn = new int[5, 5];
            int[,] wait = new int[5, 5];

            var res = ds.Calculate(arrIn);

            wait = ds.Calculate(arrIn);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
