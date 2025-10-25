using Tyuiu.DanilovAS.Sprint5.Task6.V25.Lib;
namespace Tyuiu.DanilovAS.Sprint5.Task6.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheck()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutDataFileTask6V25.txt";

            int wait = 6;
            var res = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask6V25.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
