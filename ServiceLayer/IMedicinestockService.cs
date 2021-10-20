using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public interface IMedicinestockService
    {
        Task<List<MedicineStock>> GetAllStocks();
    }
}
