using U = ChmodConverter.Utils;

namespace ChmodConverterUnitTest
{
    [TestClass]
    public class ChmodConverterTests
    {
        [TestMethod]
        public void SymbolicToNumericTest()
        {
            Assert.AreEqual("777", U.SymbolicToNumeric("rwxrwxrwx"));
            Assert.AreEqual("770", U.SymbolicToNumeric("rwxrwx---"));
            Assert.AreEqual("700", U.SymbolicToNumeric("rwx------"));
            Assert.AreEqual("400", U.SymbolicToNumeric("r--------"));
            Assert.AreEqual("444", U.SymbolicToNumeric("r--r--r--"));
            Assert.AreEqual("000", U.SymbolicToNumeric("---------"));
        }

        [TestMethod]
        public void NumericToSymbolicTest()
        {
            Assert.AreEqual("rwxrwxrwx", U.NumericToSymbolic("777"));
            Assert.AreEqual("rwxrwx---", U.NumericToSymbolic("770"));
            Assert.AreEqual("rwx------", U.NumericToSymbolic("700"));
            Assert.AreEqual("r--------", U.NumericToSymbolic("400"));
            Assert.AreEqual("r--r--r--", U.NumericToSymbolic("444"));
            Assert.AreEqual("---------", U.NumericToSymbolic("000"));
        }
    }
}