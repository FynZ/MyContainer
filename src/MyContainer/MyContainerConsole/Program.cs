using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MyContainer;
using MyContainerConsole.SampleClasses.Repositories;
using MyContainerConsole.SampleClasses.Services;

namespace MyContainerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = new Container();
            
            container.Register<IUserRepository, UserRepository>();
            container.Register<IRoleRepository, RoleRepository>();
            container.Register<IUserService, UserService>();
            container.Register<IRoleService, RoleService>();

            IRoleRepository roleRepo = container.Get<IRoleRepository>();
            IRoleService roleService = container.Get<IRoleService>();
            IUserService userService = container.Get<IUserService>();
        }
    }
}
