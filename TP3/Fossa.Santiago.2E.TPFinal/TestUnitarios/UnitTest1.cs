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
        public void CalcularTotalVacunados_RetornaTotalVacunadosListaDePaises()
        {
            //ARRAGE
            Mundo mundo = new Mundo();
            mundo.AltaPais("estados unidos", "Norteamerica", "333659530", "46949943", "761354", "193487135");
            mundo.AltaPais("india", "Asia", "1398494658", "34426036", "463245", "367698745");
            mundo.AltaPais("brasil", "Sudamerica", "214619177", "21940950", "610935", "126202217");
            mundo.AltaPais("reino unido", "Europa", "68372226", "9524971", "142835", "45985795");

            //ACT
            double totalVacunados = mundo.CalcularTotalVacunados();

            //ASSERT
            Assert.AreEqual(totalVacunados, 733373892);
        }

        [TestMethod]
        public void ValidarSoloLetras_StringConNumeros_RetornaFalse()
        {
            //ARRAGE
            string str = "palabra12";

            //ACT
            bool validacion = Validaciones.ValidarSoloLetras(str);

            //ASSERT
            Assert.IsFalse(validacion);
        }

        [TestMethod]
        public void DarFormatoNombre_RecibeUnString_DevuelveStringMayusculas()
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
