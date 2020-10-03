using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuitarStoreM.Models
{
    public class IndexViewModel
    {
        public FilterViewModel Filter { get; set; }
        public IEnumerable<Guitar> Guitars { get; set; }
    }
}
