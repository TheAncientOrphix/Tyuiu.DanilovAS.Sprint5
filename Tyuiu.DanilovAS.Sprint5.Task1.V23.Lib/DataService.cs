using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DanilovAS.Sprint5.Task1.V23.Lib
{
    public class DataService : ISprint5Task1V23
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            double f = 0;
            string strF;

            for (int i = startValue; i <= stopValue; i++)
            {
                f = Math.Cos(i) + (Math.Cos(i) / (i + 2)) - 3 * i;

                if ((i + 2) == 0)
                {
                    f = 0;
                }

                f = Math.Round(f, 2);
                strF = Convert.ToString(f);

                if (i != stopValue)
                {
                    File.AppendAllText(path, strF+ Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strF);
                }

            }
            return path;
        }
    }
}
