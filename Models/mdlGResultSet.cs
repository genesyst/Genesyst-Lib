using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyst.Models
{
    public class mdlGResultSet<T>
    {
        public int Count { get; set; }
        public int? Pages { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public List<T> Results { get; set; }
    }
}
