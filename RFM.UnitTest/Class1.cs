using RFM.Manager;
using System;
using NUnit.Framework;

namespace RFM.UnitTest
{
    [TestFixture]
    public class Class1
    {
        private File testFile;

        [Test]
        public void ShouldCreateNewFile()
        {
            var fileName = "testFile.test";
            var path = ".";

            Assert.DoesNotThrow(() => testFile = File.CreateFile(fileName, path));
            Assert.IsInstanceOf(typeof(File), testFile);
        }
    }
}
