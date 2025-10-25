using Tyuiu.DanilovAS.Sprint5.Task4.V5.Lib;
namespace Tyuiu.DanilovAS.Sprint5.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint4\InPutDataFileTask4V5.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait,fileExists);
        }
    }
}
