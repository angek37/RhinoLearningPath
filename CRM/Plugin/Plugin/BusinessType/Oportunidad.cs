using System;

namespace Plugin.BusinessType
{
    public class Oportunidad
    {
        public string Name { set; get; }
        public OrderType OrderType { set; get; }
        public Guid ContactId { set; get; }
        public double BudgetAmount { set; get; }
        public double EstimatedValue { set; get; }
        public DateTime EstimatedCloseDate { set; get; }
    }

    public enum OrderType
    {
        BasadoEnTrabajo = 192350001,
        BasadoEnArticulos = 192350000,
        BasadoEnMantenimiento = 690970002
    }
}