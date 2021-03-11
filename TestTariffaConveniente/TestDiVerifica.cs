using Microsoft.VisualStudio.TestTools.UnitTesting;
using Operazioni;

namespace TestTariffaConveniente
{
    [TestClass]
    public class TestDiVerifica
    {
        [TestMethod]
        public void TestTariffaB()
        {
            int ore = 5;
            double costoTariffa = 1;
            double risultato_aspettato = 5;
            double risultato_effettivo = Gestione.TariffaB(ore, costoTariffa);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void TestTariffaC1()
        {
            int ore = 2;
            double costoTariffa = 1.2;
            double risultato_aspettato = 2.4;
            double risultato_effettivo = Gestione.TariffaB(ore, costoTariffa);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void TestTariffaC2()
        {
            int ore = 1;
            double costoTariffa = 0;
            double risultato_aspettato = 0;
            double risultato_effettivo = Gestione.TariffaB(ore, costoTariffa);
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void TestTariffaConveniente1()
        {
            int ore = 2;
            string risposta = "";
            string risultato_effettivo = Gestione.TariffaConveniente(ore, tariffa);
            string risultato_aspettato = "TariffaC";
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }

        [TestMethod]
        public void TestTariffaConveniente2()
        {
            int ore = 24;
            string risposta = "";
            string risultato_effettivo = Gestione.TariffaConveniente(ore, tariffa);
            string risultato_aspettato = "TariffaA";
            Assert.AreEqual(risultato_aspettato, risultato_effettivo);
        }
    }
}
