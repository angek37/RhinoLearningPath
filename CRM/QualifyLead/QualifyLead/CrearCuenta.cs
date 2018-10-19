using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;
using QualifyLead.DataLayer;

namespace QualifyLead
{
    public class CrearCuenta : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            try
            {
                ServerConnection cnx = new ServerConnection(serviceProvider);
                if (!ValidaContexto(cnx))
                    return;

                cnx.context.InputParameters["CreateOpportunity"] = false;
                cnx.context.InputParameters["CreateAccount"] = true;
                cnx.context.InputParameters["CreateContact"] = true;
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException("QualifyLead.CrearCuenta: " + e.Message);
            }
        }

        public bool ValidaContexto(ServerConnection cnx)
        {
            if (cnx.context.MessageName.ToLower() != "qualifylead")
                return false;

            if (((OptionSetValue) (cnx.context.InputParameters["Status"])).Value != -1)
                return false;

            return true;
        }
    }
}
