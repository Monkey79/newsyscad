using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NewSysAcadUtils.db.impl
{
    public class NewAcadDBConnetionImpl : NewAcadDBConnection
    {
        private string _connUrl;
        private MySqlConnection _mySqlConn;

        public NewAcadDBConnetionImpl() {
            _mySqlConn = new MySqlConnection();
        }

        public MySqlConnection MySqlConn { get => _mySqlConn; }
    }
}
