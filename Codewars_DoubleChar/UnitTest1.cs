using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Codewars_DoubleChar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Input_StringEmpty_Should_Be_StringEmpty()
        {
            var input = string.Empty;
            var actual = Kata.DoubleChar(input);
            var expected = string.Empty + string.Empty;
            Assert.AreEqual(expected,actual);
        }
    }

    public class Kata
    {
        public static string DoubleChar(string input)
        {
            throw new System.NotImplementedException();
        }
    }
}
