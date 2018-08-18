using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainer
{
    public interface IContainer
    {
        //void Register<TContract, TImplementation>();
        void RegisterNamespace(string nameSpace);

        void AddTransient<TContract, TImplementation>(Func<object> implementation = null);
        void AddScoped<TContract, TImplementation>(Func<object> implementation = null);
        void AddSingleton<TContract, TImplementation>(Func<object> implementation = null);

        TContract Get<TContract>() where TContract : class;
    }
}