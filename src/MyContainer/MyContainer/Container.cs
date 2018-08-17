using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainer
{
    public class Container : IContainer
    {
        private Dictionary<Type, Type> _container;

        public Container()
        {
            _container = new Dictionary<Type, Type>();
        }

        public void Register<TContract, TImplementation>()
        {
            _container.Add(typeof(TContract), typeof(TImplementation));
        }

        public TContract Get<TContract>() where TContract : class
        {
            if (_container.TryGetValue(typeof(TContract), out Type t))
            {
                if (Activator.CreateInstance(t) is TContract obj)
                {
                    return obj;
                }
            }

            throw new Exception("Element not registered");
        }
    }
}