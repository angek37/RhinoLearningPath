using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin2.DataLayer
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
