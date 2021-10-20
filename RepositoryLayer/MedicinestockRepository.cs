using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public class MedicinestockRepository : IMedicinestockRepository
    {
        MedicineStockContext dbContext = new MedicineStockContext();

        public async Task<List<MedicineStock>> GetMedicineStocks()
        {
            List<MedicineStock> stock = new List<MedicineStock>();
            try
            {
                stock = await (from stk in dbContext.MedicineStocks select stk).ToListAsync();
                return stock;
            }
            catch (Exception)
            {
                throw new MedicineStockException(" Medicine Out Of Stock ");
            }
        }

    }
}
