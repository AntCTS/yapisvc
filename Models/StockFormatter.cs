using System;
using YahooFinanceApi;
using System.Threading;
using System.Threading.Tasks;

namespace yapisvc.Models
{
    public class StockFormatter
    {
        public string StockCode  {get;set;}
        public string StockValue {get;set;} 

        private static string sValue {get;set;}

        public void GetStockValue()
        {
            // ----- yahooAPI call ------
            //callYahoo(StockCode).Wait();
            //StockValue = sValue;

            string strPrice = "8054" + "-"+DateTime.Now.ToString();
            StockValue = String.Format("{0:1}",StockCode,strPrice );
        }

         private static async Task callYahoo(string stockCode)
         {
             var securities = await Yahoo.Symbols(stockCode).Fields(Field.Symbol, Field.RegularMarketPrice).QueryAsync();
             var stk = securities[stockCode];
             sValue = Convert.ToString(stk.RegularMarketPrice);
         }
    }
}