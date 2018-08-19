using System;
using System.Collections.Generic;
using System.Text;

namespace MyContainer
{
    class RegisteredObject
    {
        public Type ContractType { get; }
        public Type ImplementationType { get; }
        public LifeTime LifeTime { get; }

        public bool HasCustomInstanciation { get; } = false;
        public Func<object> Implementation { get; }

        private readonly object _lock = new object();
        public bool HasSetInstance { get; private set; } = false;
        public object Instance { get; private set; }

        public RegisteredObject(Type contractType, Type implementationType, LifeTime lifeTime, Func<object> implementation = null)
        {
            ContractType = contractType;
            ImplementationType = implementationType;
            LifeTime = lifeTime;

            if (implementation != null)
            {
                HasCustomInstanciation = true;
                Implementation = implementation;
            }
        }

        public object SetInstance(object instanciation)
        {
            lock (_lock)
            {
                if (!HasSetInstance)
                {
                    Console.WriteLine("Setting Instance of a Singleton");

                    HasSetInstance = true;
                    Instance = instanciation;
                }
            }

            return instanciation;
        }
    }
}