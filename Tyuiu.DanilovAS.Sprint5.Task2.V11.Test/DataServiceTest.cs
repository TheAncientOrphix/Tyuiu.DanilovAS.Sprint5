using Tyuiu.DanilovAS.Sprint5.Task2.V11.Lib;
namespace Tyuiu.DanilovAS.Sprint5.Task2.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            DataService ds = new DataService();
            string path = $@"C:\Users\shura\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = File.Exists(path);
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
