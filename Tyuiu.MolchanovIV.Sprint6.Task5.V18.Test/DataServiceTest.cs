using Tyuiu.MolchanovIV.Sprint6.Task5.V18.Lib;

namespace Tyuiu.MolchanovIV.Sprint6.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            string inputPath = $@"C:\DataSprint7\InPutDataFileTask5V18.txt";

            var res = ds.LoadFromDataFile(inputPath);

            double[] wait = ds.LoadFromDataFile(inputPath);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
