using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainer
{
    public interface IContainer
    {
        void Register<TContract, TImplementation>();
        TContract Get<TContract>() where TContract : class;
    }
}