using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainerConsole.SampleClasses.Models
{
    class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Role(string name)
        {
            Name = name;
        }
    }
}
