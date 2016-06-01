using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ.Platform.Framework.Common;
using IQ.Platform.Framework.WebApi.Model.Hypermedia;

namespace Boreal.Model
{
    public class Product : IStatelessResource, IIdentifiable<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public string Weight { get; set; }
        public string Size { get; set; }
        public bool IsAvailable { get; set; }

    }
}
