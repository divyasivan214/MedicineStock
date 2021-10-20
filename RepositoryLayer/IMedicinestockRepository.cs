using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public interface IMedicinestockRepository
    {
        Task<List<MedicineStock>> GetMedicineStocks();
    }
}
