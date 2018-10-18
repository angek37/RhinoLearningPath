using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Plugin3.BusinessType;

namespace Plugin3.DataLayer
{
    public class CrmRepository
    {
        private ServerConnection _cnx = default(ServerConnection);

        public CrmRepository(ServerConnection cnx)
        {
            _cnx = cnx;
        }

        //internal void ActualizaContacto(Contact contact)
        //{
        //    Entity entity = new Entity("contact", contact.ContactId) {["rs_edad"] = contact.Edad};
        //    _cnx.Service.Update(entity);
        //}
    }
}
