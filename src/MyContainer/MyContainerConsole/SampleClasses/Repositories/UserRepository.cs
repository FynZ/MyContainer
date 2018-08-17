using System;
using System.Collections.Generic;
using System.Text;
using MyContainerConsole.SampleClasses.Models;

namespace MyContainerConsole.SampleClasses.Repositories
{
    class UserRepository : IUserRepository
    {
        public User FindById(int id)
        {
            throw new NotImplementedException();
        }

        public User FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public User FindByMail(string mail)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(User user)
        {
            throw new NotImplementedException();
        }

        public bool BulkInsert(IEnumerable<User> users)
        {
            throw new NotImplementedException();
        }

        public bool Remove(User user)
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
