namespace ClacluclacloclaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumarTestPass()
        {
            int res = Clacluclaclocla.Program.Sumar(2, 2);

            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void SumarTestFail()
        {
            int res = Clacluclaclocla.Program.Sumar(2, 2);

            Assert.AreNotEqual(res, 2);
        }


        [TestMethod]
        public void RestarTestPass()
        {
            int res = Clacluclaclocla.Program.Restar(2, 2);

            Assert.AreEqual(res, 0);
        }
        [TestMethod]
        public void RestarTestFail()
        {
            int res = Clacluclaclocla.Program.Restar(2, 2);

            Assert.AreNotEqual(res, 2);
        }

        [TestMethod]
        public void MultiplicarTestPass()
        {
            int res = Clacluclaclocla.Program.Multiplicar(2, 2);

            Assert.AreEqual(res, 4);

        }
        [TestMethod]
        public void MultiplicarTestFail()
        {
            int res = Clacluclaclocla.Program.Multiplicar(2, 2);

            Assert.AreNotEqual(res, 5);
        }

        [TestMethod]
        public void DividirTestPass()
        {
            double res = Clacluclaclocla.Program.Dividir(2, 2);

            Assert.AreEqual(res, 1);
        }
        [TestMethod]
        public void DividirTestFail()
        {
            double res = Clacluclaclocla.Program.Dividir(2, 2);

            Assert.AreNotEqual(res, 0);
        }
    }
}