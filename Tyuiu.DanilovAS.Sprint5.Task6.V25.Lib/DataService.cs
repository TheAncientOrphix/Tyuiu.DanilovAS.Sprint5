using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DanilovAS.Sprint5.Task6.V25.Lib
{
    public class DataService : ISprint5Task6V25
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    foreach (char c in line)
                    {
                        if (c == '!')
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
