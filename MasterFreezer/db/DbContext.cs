using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterFreezer.models;
using System.Configuration;

namespace MasterFreezer.db
{
    class DbContext
    {
        private string connStr = ConfigurationManager.AppSettings["ConnectionString"];

        public SqlSugarClient db;

        public DbContext()
        {
            db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = connStr,
                DbType = DbType.MySql,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute
            });
            db.CodeFirst.InitTables(typeof(Postman));
        }
    }
}
