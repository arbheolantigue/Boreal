using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boreal.Model;

namespace BorealPersistence
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual ICollection<WarehouseItem> ItemList { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
