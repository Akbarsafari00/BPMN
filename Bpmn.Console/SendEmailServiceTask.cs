using Bpmn.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Bpmn.Console
{
    public class SendEmailServiceTask : IServiceTask<SendEmailServiceTaskOutput>
    {
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
    public class SendEmailServiceTaskOutput 
    {
        public bool IsSuccessed{ get; set; }
    }
    public class SendEmailServiceTaskhandler : IServiceTaskHandler<SendEmailServiceTask, SendEmailServiceTaskOutput>
    {

        public async Task<SendEmailServiceTaskOutput> HandleAsync(SendEmailServiceTask input)
        {
            return new SendEmailServiceTaskOutput
            {
                IsSuccessed = true
            };
        }
    }
}
