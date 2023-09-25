using NewSysAcadApp.src.main.sysacad.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad.service
{
    public interface LoginService
    {
        public User checkCredential(string username, string password);
    }
}
