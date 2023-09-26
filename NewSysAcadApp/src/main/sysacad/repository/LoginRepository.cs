using NewSysAcadApp.src.main.sysacad.entities;
using NewSysAcadApp.src.main.sysacad.repository.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad.repository
{
    public interface LoginRepository : CommonsOprt<User>
    {
        public User GetUserByUsername(string username);
        public User SaveUser(string username, string password);
    }
}
