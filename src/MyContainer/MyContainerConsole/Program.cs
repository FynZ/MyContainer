using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using MyContainer;
using MyContainerConsole.SampleClasses.Repositories;
using MyContainerConsole.SampleClasses.Services;
using MyContainerConsole.SampleClasses.Utils;

namespace MyContainerConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IContainer container = new Container();
            
            container.AddTransient<IUserRepository, UserRepository>();
            container.AddTransient<IRoleRepository, RoleRepository>();
            container.AddTransient<IUserService, UserService>();
            container.AddTransient<IRoleService, RoleService>();
            
            container.AddTransient<IMailer, Mailer>(() => new Mailer("test"));

            //IRoleRepository roleRepo = container.Get<IRoleRepository>();
            //IRoleService roleService = container.Get<IRoleService>();
            //IUserService userService = container.Get<IUserService>();

            IMailer mailer = container.Get<IMailer>();
        }
    }
}
