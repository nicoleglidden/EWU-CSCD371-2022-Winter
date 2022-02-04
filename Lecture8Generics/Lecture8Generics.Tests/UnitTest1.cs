using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lecture8Generics.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Constructor()
        {
            Dictionary<int, string> dictionary = new();
            Assert.IsNotNull(dictionary);
        }

        [TestMethod]
        public void Add()
        {
            Dictionary<int, string> dictionary = GetTestDictionary();

            Assert.AreEqual("Inigo Montoya", dictionary[42]);
        }

        [TestMethod]
        public void Count()
        {
            Dictionary<int, string> dictionary = GetTestDictionary();

            Assert.AreEqual(3, dictionary.Count);
        }
        

        [TestMethod]
        public void Exists()
        {
            Dictionary<int, string> dictionary = GetTestDictionary();

            Assert.IsTrue(dictionary.KeyExists(42));
        }
        private static Dictionary<int, string> GetTestDictionary()
        {
            Dictionary<int, string> dictionary = new();
            dictionary.Add(41, "Six fingered man");
            dictionary.Add(42, "Inigo Montoya");
            dictionary.Add(43, "Princess Buttercup");
            return dictionary;
        }

        [TestMethod]
        public void UpdatedValue()
        {
            Dictionary<int, string> dictionary = GetTestDictionary();
            dictionary[42] = "Day";

            Assert.AreEqual("Day", dictionary[42]);
        }

        public void Remove()
        {
            Dictionary<int, string> dicitionary = GetTestDictionary();
            dicitionary.Remove(42);

            Assert.IsFalse(dicitionary.KeyExists(42));
            Assert.AreEqual(2, dicitionary.Count);
        }

    }
}