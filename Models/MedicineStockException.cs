using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicineStock
{
    public class MedicineStockException : Exception
    {
        public MedicineStockException(string errMsg) : base(errMsg)
        {

        }

        public MedicineStockException() : base()
        {
        }

        public MedicineStockException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
