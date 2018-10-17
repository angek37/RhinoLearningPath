using System;
using Microsoft.Xrm.Sdk;
using Plugin.DataLayer;
using Plugin.BusinessType;
using Plugin.ExtensionMethods;

namespace Plugin
{
    public class CrearOportunidad : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                ServerConnection cnx = new ServerConnection(serviceProvider);
                CrmRepository crmRepository = new CrmRepository(cnx);
                Entity entity = (Entity) cnx.context.InputParameters["Target"];
                if (!ValidarContexto(entity, cnx))
                    return;

                ListaDePrecio listaDePrecio = crmRepository.ObtenerListaDePrecios().Find(l => l.Name == "Retail");
                Oportunidad opportunity = BuildOportunidad(entity, listaDePrecio);
                crmRepository.CrearOportunidad(opportunity);
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException();
            }
        }


        private Oportunidad BuildOportunidad(Entity entity, ListaDePrecio lista)
        {
            string nombre = entity.GetStringValue("fullname");
            Oportunidad opportunity = new Oportunidad
            {
                Name = $"OPT-{nombre}",
                OrderType = OrderType.BasadoEnTrabajo,
                ContactId = new EntityReference("contact", entity.Id),
                BudgetAmount = 1000,
                EstimatedValue = 10000,
                EstimatedCloseDate = DateTime.Now.AddMonths(1),
                PriceList = new EntityReference("pricelevel", lista.Id),
                TransactionCurrencyId = new EntityReference("transactioncurrency", lista.TransactionCurrencyId)
            };
            return opportunity;
        }

        private bool ValidarContexto(Entity entity, ServerConnection cnx)
        {
            if (entity.LogicalName.ToLower() != "contact")
                return false;

            if (cnx.context.MessageName.ToLower() != "create")
                return false;

            return true;
        }
    }
}
