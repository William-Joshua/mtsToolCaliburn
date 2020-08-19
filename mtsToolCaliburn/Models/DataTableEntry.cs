using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtsToolCaliburn.Models
{
    public class DataTableEntry
    {
        public DataTableEntry(string order, string purchasedOn, string customer, string shipTo,string basePrice,string purchasedPrice,DataTableStatus status)
        {
            Order = order;
            PurchasedOn = purchasedOn;
            Customer = customer;
            ShipTo = shipTo;
            BasePrice = basePrice;
            PurchasedPrice = purchasedPrice;
            Status = status;
        }
        public string Order { get; set; }

        public string PurchasedOn { get; set; }

        public string Customer { get; set; }

        public string ShipTo { get; set; }

        public string BasePrice { get; set; }

        public string PurchasedPrice { get; set; }

        public DataTableStatus Status { get; set; }
        
    }

    public enum DataTableStatus
    {
        Pending,
        OnHold,
        Closed
    }
}
