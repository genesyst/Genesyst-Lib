using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesyst.Models
{
    public class mdlGPostDataResponse<T>
    {
        public int Action { get; set; }
        public string Message { get; set; }
        public List<T> Datas { get; set; }
        public bool Success { get; set; }

        private DateTime date;
        public DateTime Date
        {
            get { return DateTime.Now; }
            set { date = value; }
        }
    }
}
