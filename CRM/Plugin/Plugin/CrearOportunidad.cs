using Plugin.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
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
                Entity entity = (Entity) cnx.context.InputParameters["Target"];
                if (!ValidarContexto(entity, cnx))
                    return;

                string nombre = entity.GetStringValue("fullname");
                Guid contactid = entity.GetGuidValue("contactid");

                Oportunidad opportunity = new Oportunidad();
                opportunity.Name = $"OPT-{nombre}";
                opportunity.OrderType = OrderType.BasadoEnTrabajo;
                opportunity.ContactId = contactid;
                opportunity.BudgetAmount = 1000;
                opportunity.EstimatedValue = 10000;
                opportunity.EstimatedCloseDate = DateTime.Now.AddMonths(1);
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException();
            }
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
