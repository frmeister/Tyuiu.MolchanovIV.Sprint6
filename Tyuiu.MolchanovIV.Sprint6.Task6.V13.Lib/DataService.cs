using System.Collections.Specialized;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.MolchanovIV.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    int[] count = {0, 0};

                    for (int i = 0; i < line.Length; i++)
                    {
                        char C = line[i];
                        if (C == ' ')
                        {
                            count[0] = count[1];
                            count[1] = i;
                        }
                    }

                    for (int i = count[0] + 1; i < count[1]; i++)
                    {
                        res += line[i];
                    }

                    res += " ";
                }
            }

            return res;
        }
    }
}
