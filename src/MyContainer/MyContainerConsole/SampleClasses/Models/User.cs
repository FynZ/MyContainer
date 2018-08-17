using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainerConsole.SampleClasses.Models
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Mail { get; set; }
        public string NormalizedMail { get; set; }
        public DateTime CreationDate { get; set; }

        public User(string userName, string mail)
        {
            UserName = userName;
            Mail = mail;

            NormalizedUserName = userName.ToUpperInvariant();
            NormalizedMail = mail.ToUpperInvariant();
        }
    }
}
