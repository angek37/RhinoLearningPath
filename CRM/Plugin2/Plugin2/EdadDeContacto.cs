using System;
using Microsoft.Xrm.Sdk;
using Plugin2.DataLayer;
using Plugin2.ExtensionMethods;

namespace Plugin2
{
    public class EdadDeContacto : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                ServerConnection cnx = new ServerConnection(serviceProvider);
                CrmRepository crmRepository = new CrmRepository(cnx);
                Entity entity = (Entity) cnx.context.InputParameters["Target"];
                if (!ValidaContexto(entity, cnx))
                    return;
                DateTime birthdate = entity.GetDateTimeValue("birthdate");
                int edad = (((DateTime.Now.Year - birthdate.Year) * 12) + DateTime.Now.Month - birthdate.Month) / 12;
                entity["rs_edad"] = edad;
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException();
            }
        }

        private bool ValidaContexto(Entity entity, ServerConnection cnx)
        {
            if (entity.LogicalName.ToLower() != "contact")
                return false;
            if (cnx.context.MessageName.ToLower() != "create")
                return false;
            
            return true;
        }
    }
}
