using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void CrearNuevoPais_ConParametroValidos_RetornaNoNull()
        {
            //ARRAGE
            Pais nuevoPais;

            //ACT
            nuevoPais = Pais.CrearNuevoPais("argentina", "Sudamerica", "45000000", "5000000", "116000", "27000000");

            //ASSERT
            Assert.IsNotNull(nuevoPais);
        }

        [TestMethod]
        public void EliminarPais_SiPaisExiste_RetornaTrue()
        {
            //ARRAGE
            Mundo mundo = new Mundo();
            mundo.AltaPais("Argentina", "Sudamerica", "45761013", "5304059", "116222", "27201986");
            mundo.AltaPais("españa", "Europa", "46779479", "5047156", "87673", "37448743");

            //ACT
            bool paisEliminado = mundo.EliminarPais("argentina");

            //ASSERT
            Assert.IsTrue(paisEliminado);
        }

        [TestMethod]
        public void ValidarContinente_SiExisteElContinente_LoRetornaTipoEContinente()
        {
            //ARRAGE
            string continenteStr = "Asia";

            //ACT
            EContinente continente = Pais.ValidarContinente(continenteStr);

            //ASSERT
            Assert.AreEqual(continente, EContinente.Asia);

        }

        [TestMethod]
        public void TestMethod1()
        {
            //ARRAGE
            string palabra = "paLabra";
            string palabraNueva;

            //ACT
            palabraNueva = palabra.DarFormatoNombre();

            //ASSERT
            Assert.AreEqual(palabraNueva, "PALABRA");
        }

    }
}
