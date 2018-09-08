using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityMySql
{
    public class MySqlConfiguration
    {
        public MySqlConfiguration()
        {
            SetHistoryConext("MySql.Data.MySqlClient", (conn, schema) => new MySqlHistoryContext(conn, schema));
        }
    }
}