using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public class MedicinestockService:IMedicinestockService
    {
        public async Task<List<MedicineStock>> GetAllStocks()
        {
            MedicinestockRepository repoObj = new MedicinestockRepository();
            return await repoObj.GetMedicineStocks();
        }
    }
}
