using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemplateMethod.Classes;
using Rhino.Mocks;

namespace TemplateMethodTests
{
    [TestClass]
    public class PolicemanTest
    {
        [TestMethod]
        public void Policeman_DoWork_True()
        {
            Worker policeman = new Policeman();

            Assert.AreEqual("Patrolling", policeman.DoWork());
        }
    }
}
