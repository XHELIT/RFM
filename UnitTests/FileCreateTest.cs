using NUnit.Framework;
using System;
using RFM.Manager;
using System.IO;

namespace UnitTests
{
    [TestFixture]
    public class FileCreateTest
    {
        string fileName = "file.test";
        string path;
        private string FileContent = "Sample Text";
        private DirectoryInfo testDirectory;


        [OneTimeSetUp]
        public void Init()
        {
            path = CreateTestDirectoryPath();
            testDirectory = CreateTestDirectory(path);
        }

        private string CreateTestDirectoryPath()
        {
            var currentPath = AppDomain.CurrentDomain.BaseDirectory;
            var targetDirectory = TestContext.CurrentContext.Random.GetString(6);
            return System.IO.Path.Combine(currentPath, targetDirectory);
        }


        private DirectoryInfo CreateTestDirectory(string path)
        {
            if(Directory.Exists(path))
            {
                throw new Exception($"Directory: {path} already exists");
            }

            var di = Directory.CreateDirectory(path);
            return di;
        }



        [Test]
        public void Given_FileNameAndPath_When_FileDoesNotExist_Then_FileWillBeCreated()
        {
            RFM.Manager.File f = null;            

            Assert.DoesNotThrow(() => f = RFM.Manager.File.CreateFile(fileName, path));
            Assert.IsInstanceOf<RFM.Manager.File>(f);
        }


        [Test]
        public void Given_FileNameAndPath_When_FileDoesExists_Then_FileExistsException()
        {

            //TODO
            RFM.Manager.File f = null;
            var fileName = "SameFileTest.test";

            RFM.Manager.File.CreateFile(fileName, path);
            Assert.Throws<FileExistsException>(() => f = RFM.Manager.File.CreateFile(fileName, path));
        }


        [OneTimeTearDown]
        public void CleanUp()
        {
            testDirectory.Delete(true);
        }
    }
}
