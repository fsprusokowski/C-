using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using TemplateMethod.Classes;

namespace TemplateMethodTests
{
    [TestClass]
    public class ProgrammerTest
    {
        [TestMethod]
        public void Programmer_DoWork_True()
        {
            Worker programmer = new Programmer();

            Assert.AreEqual("Coding", programmer.DoWork());
        }
    }
}
