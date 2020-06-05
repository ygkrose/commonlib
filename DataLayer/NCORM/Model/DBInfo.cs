using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// 對應到app.config的ConnectionStrings
    /// </summary>
    public class DBInfo
    {
        public DBType getDBType()
        {
            return this.DataBaseType.ToLower() == "mariadb" ?  DBType.MySql : DBType.MsSql;
        }
        public string DataBaseType { get;  set; }
     

        public virtual string DBConnection { get; set; }

        public virtual string RedisConnStr { get; set; }

    }
}
