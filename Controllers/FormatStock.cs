using Microsoft.AspNetCore.Mvc;
using yapisvc.Models;

namespace yapisvc.Controllers
{
    [Route("api/[controller]")]
    public partial class getStockPrice : Controller
    {
        public IActionResult Post([FromBody]FormattedStock fStock)
        {
            if(fStock!=null)
            {
                StockFormatter.StockCode = fStock.StockCode;
                StockFormatter.GetStockValue();
                return Ok(StockFormatter.StockValue);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
