using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainerConsole.SampleClasses.Utils
{
    interface IMailer
    {
        void Send(string from, string to, string subject, string content);
    }
}
