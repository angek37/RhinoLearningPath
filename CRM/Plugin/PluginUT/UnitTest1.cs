using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Plugin.BusinessType;
using PluginUT.DataLayerUT;

namespace PluginUT
{
    [TestClass]
    public class UnitTest1
    {
        private CrmRepositoryUT _crmRepository = default(CrmRepositoryUT);

        [TestInitialize]
        public void TestInitialize()
        {
            ServerConnectionUT cnx = new ServerConnectionUT();
            _crmRepository = new CrmRepositoryUT(cnx);
        }

        [TestMethod]
        public void CreaLaOportunidad()
        {
            // Arrange
            ListaDePrecio listaDePrecio = _crmRepository.ObtenerListaDePrecios().Find(l => l.Name == "Retail");
            Oportunidad op = new Oportunidad
            {
                Name = $"OPT-Miguel",
                OrderType = OrderType.BasadoEnTrabajo,
                ContactId = new EntityReference("contact", new Guid("DFEA0607-1DD2-E811-A963-000D3A3AB6B4")),
                BudgetAmount = 1000,
                EstimatedValue = 10000,
                EstimatedCloseDate = DateTime.Now.AddMonths(1),
                PriceList = new EntityReference("pricelevel", listaDePrecio.Id),
                TransactionCurrencyId = new EntityReference("transactioncurrency", listaDePrecio.TransactionCurrencyId)
            };
            // Act
            Guid result = _crmRepository.CrearOportunidad(op);
            // Assert
            Assert.AreNotEqual(default(Guid), result);
        }
    }
}