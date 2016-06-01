using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.Framework.Common;
using IQ.Platform.Framework.WebApi.Model.Hypermedia;

namespace Boreal.Model
{
    public class Warehouse : IStatelessResource, IIdentifiable<int>
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<WarehouseItem> ItemList { get; set; }
    }
}
