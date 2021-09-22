using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace iski_proje
{
    class dbConnection
    {
        public MySqlConnection cn;
        public void Connect()
        {
            cn = new MySqlConnection("SERVER = 127.0.0.1;Uid=root;pwd=123; Port=3306;database=cesme;SSL Mode=None;");
        }
    }
}
