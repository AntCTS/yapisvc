using System;
using YahooFinanceApi;
using System.Threading;
using System.Threading.Tasks;

namespace yapisvc.Models
{
    public static class StockFormatter
    {
        public static string StockCode  {get;set;}
        public static string StockValue {get;set;} 

        private static string sValue {get;set;}

        public static void GetStockValue()
        {
            // ----- yahooAPI call ------
            callYahoo(StockCode).Wait();
            StockValue = sValue;
            StockValue = String.Format("{0}:{1}",StockCode,StockValue );
        }

         private static async Task callYahoo(string stockCode)
         {
             var securities = await Yahoo.Symbols(stockCode).Fields(Field.Symbol, Field.RegularMarketPrice).QueryAsync();
             var stk = securities[stockCode];
             sValue = Convert.ToString(stk.RegularMarketPrice);
         }
    }
}
