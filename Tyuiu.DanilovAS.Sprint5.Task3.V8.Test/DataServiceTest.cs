using Tyuiu.DanilovAS.Sprint5.Task3.V8.Lib;
namespace Tyuiu.DanilovAS.Sprint5.Task3.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestSaveToFileTextData()
        {
            string path = $@"C:\Users\shura\AppData\Local\Temp\OutPutFileTask2.csv";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = File.Exists(path);
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
