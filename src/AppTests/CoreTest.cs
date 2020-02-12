using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppCore;

namespace AppTests
{
    [TestClass]
    public class CoreTests
    {
        [TestMethod]
        public void PersonDescriptionTest()
        {
            var name = "Mouez";
            var age = 28;
            var person = new Person(name, age);

            Assert.AreEqual(name, person.Name);
            Assert.AreEqual(age, person.Age);
        }
    }
}