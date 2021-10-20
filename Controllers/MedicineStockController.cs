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
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(MedicineStockController));
        private readonly IMedicinestockService imedicineObj;
        public MedicineStockController(IMedicinestockService msr)
        {
            imedicineObj = msr;
        }
        [HttpGet]
        public async Task<IActionResult> GetStock()
        {
            _log4net.Info("GetStock function invoked");
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
