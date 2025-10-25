using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DanilovAS.Sprint5.Task7.V19.Lib
{
    public class DataService : ISprint5Task7V19
    {
        public string LoadDataAndSave(string path)
        {
            string tempPathForSaveFile = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPathForSaveFile, "OutPutDataFileTask7V19.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string text = File.ReadAllText(path);

            string newText = text.Replace("сс", "");
            newText = newText.Replace("Сс", "");

            File.AppendAllText(pathSaveFile, newText + Environment.NewLine);
            
            return pathSaveFile;
        }
    }
}
