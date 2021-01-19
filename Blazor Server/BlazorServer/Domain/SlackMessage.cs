using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Domain
{
    public class SlackMessage
    {
        public string PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public string Message { get; set; }
    }
}
