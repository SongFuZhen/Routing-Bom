using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoutingAndBom
{
    class routing_info_data
    {
        public string EPBANr { get; set; }
        public string PartNr { get; set; }
        public string WorkStation { get; set; }
        public Dictionary<string, int> Part { get; set; }
    }
}
