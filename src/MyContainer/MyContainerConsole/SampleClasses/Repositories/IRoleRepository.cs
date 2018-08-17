using System;
using System.Collections.Generic;
using System.Text;
using MyContainerConsole.SampleClasses.Models;

namespace MyContainerConsole.SampleClasses.Repositories
{
    interface IRoleRepository
    {
        Role FindById(int id);
        Role FindByName(string name);
        IEnumerable<Role> FindAll();
        bool Insert(Role role);
        bool BulkInsert(IEnumerable<Role> roles);
        bool Remove(Role role);
        bool Update(Role role);
    }
}
