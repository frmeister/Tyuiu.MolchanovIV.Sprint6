using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task0.V7.Lib
{
    public class DataService : ISprint6Task0V7
    {
        public double Calculate(int x)
        {
            double res = 0.0;

            res = Math.Round(Math.Pow(x, 3) / (2 * (Math.Pow(x + 5, 2))), 3);

            return res;
        }
    }
}
