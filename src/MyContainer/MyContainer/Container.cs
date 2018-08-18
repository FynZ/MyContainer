using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MyContainer
{
    public class Container : IContainer
    {
        private readonly Dictionary<Type, RegisteredObject> _container;

        public Container()
        {
            _container = new Dictionary<Type, RegisteredObject>();
        }

        public void Register<TContract, TImplementation>()
        {
        }

        public void AddTransient<TContract, TImplementation>(Func<object> implementation = null)
        {
            _container.Add(typeof(TContract), new RegisteredObject(typeof(TContract), typeof(TImplementation), LifeTime.Transient, implementation));
        }

        // I don't even know how i'm going to do this as I dont have an HttpContext (yet ?)
        public void AddScoped<TContract, TImplementation>(Func<object> implementation = null)
        {
            _container.Add(typeof(TContract), new RegisteredObject(typeof(TContract), typeof(TImplementation), LifeTime.Scoped, implementation));
        }

        public void AddSingleton<TContract, TImplementation>(Func<object> implementation = null)
        {
            _container.Add(typeof(TContract), new RegisteredObject(typeof(TContract), typeof(TImplementation), LifeTime.Singleton, implementation));
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
            if (_container.TryGetValue(interfaceType, out RegisteredObject registeredObject))
            {
                if (registeredObject.HasCustomInstanciation)
                {
                    return registeredObject.Implementation.Invoke();
                }
                // We take the most parameterized constructor
                var constructor = registeredObject.ImplementationType.GetConstructors()
                    .OrderByDescending(x => x.CustomAttributes.Count()).FirstOrDefault();

                // Parameterized Constructor
                if (constructor != null && constructor.GetParameters().Length > 0 )
                {
                    var parameters = GetConstructorParameters(registeredObject.ImplementationType);

                    return Activator.CreateInstance(registeredObject.ImplementationType, parameters.ToArray());
                }

                // Parameterless Constructor
                return Activator.CreateInstance(registeredObject.ImplementationType);
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