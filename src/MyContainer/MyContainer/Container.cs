using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        public void RegisterNamespace(string nameSpace)
        {
            var test = this.GetType().Assembly;
            
            throw new NotImplementedException();
        }

        public TContract Get<TContract>() where TContract : class
        {
            return (TContract) GetObject(typeof(TContract));
        }

        private object GetObject(Type interfaceType)
        {
            if (_container.TryGetValue(interfaceType, out Type implementationType))
            {
                var constructor = implementationType.GetConstructors().OrderByDescending(x => x.CustomAttributes.Count()).First();

                // Parameterized Constructor
                if (constructor != null && constructor.GetParameters().Length > 0 )
                {
                    var parameters = GetConstructorParameters(implementationType);

                    return Activator.CreateInstance(implementationType, parameters.ToArray());
                }

                // Parameterless Constructor
                return Activator.CreateInstance(implementationType);
            }

            throw new Exception("Element not registered");
        }

        private IEnumerable<object> GetConstructorParameters(Type t)
        {
            var constructor = t.GetConstructors().First();
            foreach (var param in constructor.GetParameters())
            {
                yield return GetObject(param.ParameterType);
            }
        }
    }
}