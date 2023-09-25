using NewSysAcadApp.src.main.sysacad.entities;
using NewSysAcadUtils.db;
using NewSysAcadUtils.db.impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad.repository.impl
{
    public class LoginRepositoryImpl : LoginRepository
    {
        private const string GET_USER_BY_NAME = "SELECT * from USER WHERE name=?";

        private NewAcadDBConnection _dBConnection;

        public LoginRepositoryImpl(){
            _dBConnection = new NewAcadDBConnetionImpl();
        }

        public User getUserByUsername(string username) {
            throw new NotImplementedException();
        }

        public User saveUser(string username, string password){
            throw new NotImplementedException();
        }
    }
}
