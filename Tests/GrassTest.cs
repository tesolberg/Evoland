using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Evoland;

namespace Tests {
    [TestClass]
    public class GrassTest {
        [TestMethod]
        public void TestMethod1() {
            Grass grass = new Grass();
            for (int i = 0; i < 100; i++) {
                Console.WriteLine("Grass amount: " + grass.GrassValue);
                grass.Run();
            }

        }
    }
}
