using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task2.V13.Lib
{
    public class DataService : ISprint6Task2V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int arrLen = stopValue - startValue + 1, curValue = startValue;

            double[] res = new double[arrLen];

            for (int i = 0; i < arrLen; i++)
            {
                res[i] = Math.Sin(curValue);
                res[i] += 2 * curValue / 3;
                res[i] -= Math.Cos(curValue) * 4 * curValue;
                res[i] = Math.Round(res[i], 2);

                curValue++;
            }

            return res;
        }
    }
}
/*
 real: [0.0,0.0,5.24,14.02,11.7,-3.63,-19.32,-16.45,10.65,39.21,39.02]
expected: [3.63,-11.7,-14.02,-5.24,1.32,0.0,-1.32,5.24,14.02,11.7,-3.63]
 */