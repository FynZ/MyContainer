using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainer
{
    public interface IContainer
    {
        void Register<TContract, TImplementation>();
        void RegisterNamespace(string nameSpace);
        TContract Get<TContract>() where TContract : class;
    }
}