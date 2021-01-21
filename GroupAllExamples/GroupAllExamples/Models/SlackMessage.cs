using System;

namespace GroupAllExamples.Models
{
    public class SlackMessage
    {
        public int Id { get; set; }
        public string PostedBy { get; set; }
        public DateTime PostedOn { get; set; }
        public string Message { get; set; }
        public int Like { get; set; }
    }
}
