using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager
{
    public class ValuesHolder
    {
        private List<string> values;
        public List<string> Values { get => values; set => values = value; }

        public ValuesHolder()
        {
            values = new List<string>();
        }
    }
}
