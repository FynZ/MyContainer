using System;
using System.Collections.Generic;
using System.Text;
using MyContainerConsole.SampleClasses.Models;
using MyContainerConsole.SampleClasses.Repositories;

namespace MyContainerConsole.SampleClasses.Services
{
    class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User Create()
        {
            throw new NotImplementedException();
        }
    }
}
