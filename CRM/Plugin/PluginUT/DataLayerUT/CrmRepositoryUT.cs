using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Plugin.BusinessType;
using Plugin.ExtensionMethods;

namespace PluginUT.DataLayerUT
{
    public class CrmRepositoryUT
    {
        private ServerConnectionUT _cnx = default(ServerConnectionUT);

        public CrmRepositoryUT(ServerConnectionUT cnx)
        {
            _cnx = cnx;
        }

        internal Guid CrearOportunidad(Oportunidad oportunidad)
        {
            Entity entity = new Entity("opportunity");
            entity["name"] = oportunidad.Name;
            entity["msdyn_ordertype"] = new OptionSetValue((int)oportunidad.OrderType);
            entity["budgetamount"] = new Money(oportunidad.BudgetAmount);
            entity["estimatedvalue"] = new Money(oportunidad.EstimatedValue);
            entity["estimatedclosedate"] = oportunidad.EstimatedCloseDate;
            entity["contactid"] = oportunidad.ContactId;
            entity["pricelevelid"] = oportunidad.PriceList;
            entity["transactioncurrencyid"] = oportunidad.TransactionCurrencyId;
            return _cnx.service.Create(entity);
        }

        internal List<ListaDePrecio> ObtenerListaDePrecios()
        {
            string query = $@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false'>
              <entity name='pricelevel'>
                <attribute name='name' />
                <attribute name='transactioncurrencyid' />
                <attribute name='pricelevelid' />
                <order attribute='name' descending='false' />
                <filter type='and'>
                  <condition attribute='msdyn_entity' operator='not-in'>
                    <value>192350002</value>
                    <value>192350003</value>
                  </condition>
                </filter>
              </entity>
            </fetch>";
            EntityCollection entitiesCollection = _cnx.service.RetrieveMultiple(new FetchExpression(query));
            return CollectionToList(entitiesCollection);
        }

        private List<ListaDePrecio> CollectionToList(EntityCollection collection)
        {
            List<ListaDePrecio> list = new List<ListaDePrecio>();
            foreach (var entity in collection.Entities)
            {
                list.Add(EntityAListaDePrecio(entity));
            }
            return list;
        }

        private ListaDePrecio EntityAListaDePrecio(Entity entity)
        {
            ListaDePrecio lista = new ListaDePrecio();
            lista.Name = entity.GetStringValue("name");
            lista.Id = entity.Id;
            lista.TransactionCurrencyId = entity.GetEntityReferenceId("transactioncurrencyid");
            return lista;
        }

    }
}
