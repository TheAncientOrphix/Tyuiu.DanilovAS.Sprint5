using System.Diagnostics;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DanilovAS.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            string tempPath = Path.GetTempPath();
            string path = Path.Combine(tempPath, "OutPutFileTask0.txt");
            //string path = Path.Combine("C:", "Users" , "shura" , "source" , "repos" , "Tyuiu.DanilovAS.Sprint5" , "Tyuiu.DanilovAS.Sprint5.Task0.V6" , "bin" , "Debug" , "net8.0" , "OutPutFileTask0.txt");

            double z = x / (Math.Sqrt(Math.Pow(x, 2) + x));
            z = Math.Round(z, 3);

            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
