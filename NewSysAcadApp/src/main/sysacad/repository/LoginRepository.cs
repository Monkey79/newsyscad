using NewSysAcadApp.src.main.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad.repository
{
    public interface LoginRepository
    {
        public User getUserByUsername(string username);
        public User saveUser(string username, string password);
    }
}
