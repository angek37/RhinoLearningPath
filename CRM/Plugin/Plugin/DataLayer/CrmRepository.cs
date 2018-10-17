using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using Plugin.BusinessType;

namespace Plugin.DataLayer
{
    public class CrmRepository
    {
        private ServerConnection _cnx = default(ServerConnection);

        public CrmRepository(ServerConnection cnx)
        {
            _cnx = cnx;
        }

        internal void CrearOportunidad(Oportunidad oportunidad)
        {
            Entity entity = new Entity("opportunity");
            entity["name"] = oportunidad.Name;
            entity["msdyn_ordertype"] = oportunidad.OrderType;
            entity["budgetamount"] = oportunidad.BudgetAmount;
            entity["estimatedvalue"] = oportunidad.EstimatedValue;
            entity["estimatedclosedate"] = oportunidad.EstimatedCloseDate;
            _cnx.service.Create(entity);
        }
    }
}
