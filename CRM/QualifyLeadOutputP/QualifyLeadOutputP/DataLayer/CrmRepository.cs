using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using QualifyLeadOutputP.ExtensionMethods;

namespace QualifyLeadOutputP.DataLayer
{
    public class CrmRepository
    {
        private ServerConnection _cnx = default(ServerConnection);

        public CrmRepository(ServerConnection cnx)
        {
            _cnx = cnx;
        }

        internal Entity GetAccount(Guid accountid)
        {
            Entity entity = new Entity("account", accountid);

            return entity;
        }
    }
}
