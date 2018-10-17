using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin.BusinessType
{
    public class ListaDePrecio
    {
        public Guid Id { set; get; }
        public string Name { set; get; }
        public Guid TransactionCurrencyId { set; get; }
    }
}
