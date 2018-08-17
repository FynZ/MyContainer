using System;
using System.Collections.Generic;
using System.Text;
using MyContainerConsole.SampleClasses.Models;

namespace MyContainerConsole.SampleClasses.Repositories
{
    interface IUserRepository
    {
        User FindById(int id);
        User FindByName(string name);
        User FindByMail(string mail);
        IEnumerable<User> FindAll();
        bool Insert(User user);
        bool BulkInsert(IEnumerable<User> users);
        bool Remove(User user);
        bool Update(User user);
    }
}
