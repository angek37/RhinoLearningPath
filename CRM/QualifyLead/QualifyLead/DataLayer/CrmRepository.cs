using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using QualifyLead.ExtensionMethods;

namespace QualifyLead.DataLayer
{
    public class CrmRepository
    {
        private ServerConnection _cnx = default(ServerConnection);

        public CrmRepository(ServerConnection cnx)
        {
            _cnx = cnx;
        }

    }
}
