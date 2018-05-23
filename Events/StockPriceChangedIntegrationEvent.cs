using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yapisvc.Events
{
    public class StockPriceChangedIntegrationEvent : IntegrationEvent
    {
        public string StockCode { get; private set; }
        public string NewPrice { get; private set; }
        public string OldPrice { get; private set; }

        public StockPriceChangedIntegrationEvent(string stockcode, string newPrice, string oldPrice)
        {
            StockCode = stockcode;
            NewPrice = newPrice;
            OldPrice = oldPrice;
        }
    }
}