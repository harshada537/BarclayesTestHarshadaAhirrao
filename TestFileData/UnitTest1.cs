using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using System.Configuration;

namespace TestFileData
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVersionPositive()
        {
            string[] a = new string[] { "-v", "C:/test.txt" };
           
            Program.Main(a);
        }

        [TestMethod]
        public void TestSizePositive()
        {
            string[] a = new string[] { "-s", "C:/test.txt" };

            Program.Main(a);
        }

        [TestMethod]
        public void TestNegative()
        {
            string[] a = new string[] { "-l", "C:/test.txt" };

            Program.Main(a);
        }
    }
}
