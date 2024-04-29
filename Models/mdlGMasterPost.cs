using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyst.Models
{
    public class mdlGMasterPost<T>
    {
        public GPostType PostType { get; set; }
        public Object AccessBy { get; set; }
        public bool Return { get; set; }
        public List<T> Datas { get; set; }
    }
}
