using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Plugin3.BusinessType;

namespace Plugin3UT.DataLayerUT
{
    public class CrmRepositoryUT
    {
        private ServerConnectionUT _cnx = default(ServerConnectionUT);

        public CrmRepositoryUT(ServerConnectionUT cnx)
        {
            _cnx = cnx;
        }

        internal void ActualizaContacto(Contact contact)
        {
            Entity entity = new Entity("contact", contact.ContactId) { ["rs_edad"] = contact.Edad };
            _cnx.service.Update(entity);
        }
    }
}
