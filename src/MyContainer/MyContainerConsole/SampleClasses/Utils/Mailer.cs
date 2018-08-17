using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainerConsole.SampleClasses.Utils
{
    class Mailer : IMailer
    {
        public void Send(string from, string to, string subject, string content)
        {
            throw new NotImplementedException();
        }
    }
}
