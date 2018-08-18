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
    }
}