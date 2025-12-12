using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task5.V18.Lib
{
    public class DataService : ISprint6Task5V18
    {
        public double[] LoadFromDataFile(string path)
        {
            int len = 0;
            int count = 0;

            string filepath = $@"{Path.GetTempPath()}";
            string filename = "OutPutDataFileTask5V18.txt";
            string outputPath = Path.Combine(filepath, filename);

            if (File.Exists(outputPath)) File.Delete(outputPath);

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len += 1;
                }
            }

            double[] res = new double[len];

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    double curNum = Convert.ToDouble(line);

                    if (!double.IsInteger(curNum))
                    {
                        res[count] = Convert.ToDouble(line);
                        count++;
                    }
                }
            }

            double[] output = new double[count];
            int c = 0;

            for (int i = 0; i < res.Length; i++)
            {
                
                if (res[i] == 0) break;
                output[c] = res[i];
                c++;
            }

        return output;
        }
    }
}
