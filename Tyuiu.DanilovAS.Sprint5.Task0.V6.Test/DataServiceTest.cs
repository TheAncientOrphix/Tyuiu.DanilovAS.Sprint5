using System.Diagnostics;
using Tyuiu.DanilovAS.Sprint5.Task0.V6.Lib;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;
namespace Tyuiu.DanilovAS.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\shura\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = File.Exists(path);
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
