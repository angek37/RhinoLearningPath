﻿using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
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
                Entity entity = (Entity) cnx.context.InputParameters["Target"];
                if (!ValidaContexto(entity, cnx))
                    return;

                DateTime birthdate = entity.GetDateTimeValue("birthdate");
                int edad = CalculaEdad(birthdate);
                entity["rs_edad"] = edad;
            }
            catch (Exception e)
            {
                throw new InvalidPluginExecutionException("Plugin2.EdadDeContacto: " + e.Message);
            }
        }

        private int CalculaEdad(DateTime birthdate)
        {
            return (((DateTime.Now.Year - birthdate.Year) * 12) + DateTime.Now.Month - birthdate.Month) / 12;
        }

        private bool ValidaContexto(Entity entity, ServerConnection cnx)
        {
            if (entity.LogicalName.ToLower() != "contact")
                return false;
            if (cnx.context.MessageName.ToLower() != "create")
                return false;
            if (!(entity.Contains("birthdate") && entity["birthdate"] != null))
                return false;

            return true;
        }
    }
}
