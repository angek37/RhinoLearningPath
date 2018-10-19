using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using QualifyLeadOutputP.DataLayer;

namespace QualifyLeadOutputP
{
    public class ObtenerRegistrosCreados : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                ServerConnection cnx = new ServerConnection(serviceProvider);
                CrmRepository crm = new CrmRepository(cnx);
                ValidaContexto(cnx);

                foreach (EntityReference created in (IEnumerable<Object>)cnx.context.OutputParameters["CreatedEntities"])
                {
                    if (created.LogicalName == "account")
                    {
                        Entity account = crm.GetAccount(created.Id);
                    }
                }
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException("QualifyLeadOutputP.ObtenerRegistros: " + e.Message);
            }
        }

        private bool ValidaContexto(ServerConnection cnx)
        {
            if (cnx.context.MessageName.ToLower() != "qualifylead")
                return false;

            if (cnx.context.PrimaryEntityName.ToLower() != "lead")
                return false;

            if (!((IEnumerable<object>)cnx.context.OutputParameters["CreatedEntities"]).Any())
                return false;

            return true;
        }
    }
}
