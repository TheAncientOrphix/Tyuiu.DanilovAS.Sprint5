using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DanilovAS.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            strX = strX.Replace('.', ',');

            double x = Convert.ToDouble(strX);
            double y = (4.26 * x )/ (Math.Sin(x));

            return Math.Round(y,3);
        }
    }
}
