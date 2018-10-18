using System;
using Microsoft.Xrm.Sdk;
using Plugin3.DataLayer;
using Plugin3.BusinessType;
using Plugin3.ExtensionMethods;

namespace Plugin3
{
    public class AjustaEdadContacto : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                ServerConnection cnx = new ServerConnection(serviceProvider);
                Entity entity = cnx.Context.InputParameters["Target"] as Entity;
                if (!ValidaContexto(cnx, entity))
                    return;

                DateTime birthdate = entity.GetDateTimeValue("birthdate");
                entity["rs_edad"] = CalculaEdad(birthdate);
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException("Plugin3.AjustaEdadContacto: " + e.Message);
            }
        }

        private int CalculaEdad(DateTime birthdate)
        {
            return (((DateTime.Now.Year - birthdate.Year) * 12) + DateTime.Now.Month - birthdate.Month) / 12;
        }

        public bool ValidaContexto(ServerConnection cnx, Entity entity)
        {
            if (cnx.Context.MessageName.ToLower() != "update")
                return false;
            if (entity.LogicalName.ToLower() != "contact")
                return false;

            if (!(entity.Contains("birthdate") && entity["birthdate"] != null))
                return false;

            return true;
        }
    }
}
