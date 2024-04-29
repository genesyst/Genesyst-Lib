using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyst.Models
{
    public class mdlGPostResponse
    {
        public int Action { get; set; }
        public string Message { get; set; }
        public List<mdlGValue> Values { get; set; }

        private DateTime date;
        public DateTime Date
        {
            get { return DateTime.Now; }
            set { date = value; }
        }
    }
}
