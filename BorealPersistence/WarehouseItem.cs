using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorealPersistence
{
    public class WarehouseItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int LocationId { get; set; }
        public string TaxRate { get; set; }

    }
}
