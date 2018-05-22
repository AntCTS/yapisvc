using Microsoft.AspNetCore.Mvc;
using yapisvc.Models;


namespace yapisvc.Controllers
{
    [Route("api/[controller]")]
    partial class FormatStock : Controller
    {
        StockFormatter formatter = new StockFormatter();

        public IActionResult Post([FromBody] FormattedStock fStock)
        {
            if(fStock!=null)
            {
                formatter.StockCode = fStock.StockCode;
                formatter.GetStockValue();
                return Ok(formatter.StockValue);
            }
            else
            {
                return BadRequest();
            }

        }

    }

}