using System;
using System.Collections.Generic;
using System.Text;
using MyContainerConsole.SampleClasses.Models;

namespace MyContainerConsole.SampleClasses.Repositories
{
    class RoleRepository : IRoleRepository
    {
        public Role FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Role FindByName(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Role role)
        {
            throw new NotImplementedException();
        }

        public bool BulkInsert(IEnumerable<Role> roles)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Role role)
        {
            throw new NotImplementedException();
        }

        public bool Update(Role role)
        {
            throw new NotImplementedException();
        }
    }
}
