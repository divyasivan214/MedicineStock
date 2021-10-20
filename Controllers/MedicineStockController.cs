using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStockController : ControllerBase
    {
        private readonly IMedicinestockService imedicineObj;
        public MedicineStockController(IMedicinestockService msr)
        {
            imedicineObj = msr;
        }
        [HttpGet]
        public async Task<IActionResult> GetStock()
        {
            List<MedicineStock> medStock = await (imedicineObj.GetAllStocks());
            if (medStock != null)
            {
                return Ok(medStock);
            }
            else
            {
                return NoContent();
            }
        }
    }
}
