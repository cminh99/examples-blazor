using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SlackClone.Domain
{
    public class SlackMessage
    {
        public DateTime PostedOn { get; set; }
        public string PostedBy { get; set; }
        public string Message { get; set; }
        public int Like { get; set; }
    }
}
