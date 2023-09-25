using NewSysAcadApp.src.main.sysacad.entities;
using NewSysAcadApp.src.main.sysacad.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad.service.impl
{
    public class LoginServiceImpl : LoginService
    {
        private LoginRepository loginRepository;

        public LoginServiceImpl() { 
        
        }

        public User checkCredential(string username, string password) {
            User user = null;
            user = loginRepository.getUserByUsername(username);
            return user;
        }
    }
}
