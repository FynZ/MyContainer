using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainerConsole.SampleClasses.Utils
{
    class Mailer : IMailer
    {
        private string _from;

        public Mailer(string from)
        {
            _from = from;
        }

        public void Send(string from, string to, string subject, string content)
        {
            throw new NotImplementedException();
        }
    }
}
