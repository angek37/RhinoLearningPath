﻿using System;
using System.Collections.Generic;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Plugin2.BusinessType;
using Plugin2.ExtensionMethods;

namespace Plugin2UT.DataLayerUT
{
    public class CrmRepositoryUT
    {
        private ServerConnectionUT _cnx = default(ServerConnectionUT);

        public CrmRepositoryUT(ServerConnectionUT cnx)
        {
            _cnx = cnx;
        }

        
    }
}
