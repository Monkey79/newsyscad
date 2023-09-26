﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadApp.src.main.sysacad.repository.impl
{
    public abstract class BaseRepo
    {
        protected  const string CONNN_URL = "server=localhost; uid=root; database=SysacadDb; port=3306; pwd=root;";

        protected MySqlConnection _mySqlConn;
        protected MySqlCommand _mySqlComnd;
        protected MySqlDataReader _mySqlRead;

        public MySqlConnection MySqlConn { get => _mySqlConn; }
        public MySqlCommand MySqlCom { get => _mySqlComnd; }
        public MySqlDataReader MySqlRead { get => _mySqlRead;  }
    }
}
