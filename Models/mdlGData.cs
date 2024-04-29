using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyst.Models
{
    public class mdlGData
    {
        public virtual bool ACTIVE { get; set; }
        public virtual string STT { get; set; }
        public virtual Guid? UPDATE_BY { get; set; }
        public virtual DateTime? UPDATE_DATE { get; set; }
        public virtual Guid CREATE_BY { get; set; }
        public virtual DateTime CREATE_DATE { get; set; }
    }
}
