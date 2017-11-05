using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject5
{
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]
        public void TestMethod1()
        {
           System.Diagnostics.Debug.WriteLine("test5 ...");
            throw new Exception();

        }
    }
}
