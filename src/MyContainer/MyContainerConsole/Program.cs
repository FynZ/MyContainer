using System;
using System.Security.Cryptography.X509Certificates;
using MyContainer;
using MyContainerConsole.SampleClasses.Repositories;

namespace MyContainerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = new Container();
            
            container.Register<IUserRepository, UserRepository>();
            container.Register<IRoleRepository, RoleRepository>();

            IRoleRepository roleRepo = container.Get<IRoleRepository>();
        }
    }
}
