using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using BusinessType;
using DataInterface;
using DataLayer.CRM;
using DataLayer.ExtensionMethods;

namespace DataLayer
{
    public class AccountRepository : IAccountRepository
    {
        public List<Account> GetAccounts()
        {
            ServerConnection cnx = new ServerConnection();
            string query =
                $@"<fetch version='1.0' output-format='xml-platform' mapping='logical' distinct='false' no-lock='true'>
                                  <entity name='account'>
                                    <attribute name='name' />
                                    <attribute name='accountid' />
                                    <attribute name='createdon' />
                                    <attribute name='address1_country' />
                                    <attribute name='address1_stateorprovince' />
                                    <attribute name='address1_city' />
                                    <order attribute='name' descending='false' />
                                  </entity>
                                </fetch>";
            EntityCollection collection = cnx.Service.RetrieveMultiple(new FetchExpression(query));
            if (collection != null && collection.Entities.Any())
                return CollectionToList(collection);

            return null;
        }

        public Guid CreateAccount(Account account)
        {
            try
            {
                ServerConnection cnx = new ServerConnection();
                Guid accountId = cnx.Service.Create(BuildEntity(account));
                return accountId;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #region Private Methods

        private List<Account> CollectionToList(EntityCollection collection)
        {
            List<Account> list = new List<Account>();
            foreach (var item in collection.Entities)
            {
                list.Add(EntityToAccount(item));
            }

            return list;
        }

        private Account EntityToAccount(Entity entity)
        {
            Account account = new Account
            {
                AccountId = entity.GetGuidValue("accountid"),
                Name = entity.GetStringValue("name"),
                City = entity.GetStringValue("address1_city"),
                State = entity.GetStringValue("address1_stateorprovince"),
                Country = entity.GetStringValue("address1_country"),
                CreatedOn = entity.GetDateTimeValue("createdon")
            };
            return account;
        }

        private Entity BuildEntity(Account account)
        {
            Entity entity = new Entity("account");

            if (account.AccountId != default(Guid))
                entity["accountid"] = account.AccountId;

            if (!string.IsNullOrEmpty(account.Name))
                entity["name"] = account.Name;

            if (!string.IsNullOrEmpty(account.City))
                entity["address1_city"] = account.City;

            if (!string.IsNullOrEmpty(account.State))
                entity["address1_stateorprovince"] = account.State;

            if (!string.IsNullOrEmpty(account.Country))
                entity["address1_country"] = account.Country;

            if (account.CreatedOn != default(DateTime))
                entity["createdon"] = account.CreatedOn;

            return entity;
        }
        #endregion
    }
}
