using System;
using Microsoft.Xrm.Sdk;

namespace Plugin.BusinessType
{
    public class Oportunidad
    {
        public string Name { set; get; }
        public OrderType OrderType { set; get; }
        public EntityReference ContactId { set; get; }
        public decimal BudgetAmount { set; get; }
        public decimal EstimatedValue { set; get; }
        public DateTime EstimatedCloseDate { set; get; }
        public EntityReference PriceList { set; get; }
        public EntityReference TransactionCurrencyId { set; get; }
    }

    public enum OrderType
    {
        BasadoEnTrabajo = 192350001,
        BasadoEnArticulos = 192350000,
        BasadoEnMantenimiento = 690970002
    }
}