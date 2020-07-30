using Google.Protobuf.WellKnownTypes;
using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;

namespace NewCity.DataAccess
{
    /// <summary>
    /// 資料庫實體
    /// </summary>
    public class DBEntity  
    {
        public DBType DBType { get; set; } 

        public string DBConnStr { get; set; }

        public int DBTimeout { get; set; }

        IDbConnection _conn;
        public IDbConnection DBConnection
        {
            get 
            {
                if (_conn.State != ConnectionState.Open)
                    _conn.Open();
                return _conn;
            }
            set { _conn = value; }
        }

        internal DB db;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="dbtyp">資料庫類別</param>
        /// <param name="connstr">連線字串</param>
        /// <param name="cmdtimeout">逾時設定</param>
        public DBEntity(DBType dbtyp, string connstr, int cmdtimeout = 30)
        {
            DBConnStr = connstr;
            DBTimeout = cmdtimeout;
            DBType = dbtyp;
            if (connstr.ToLower().StartsWith("server="))
                db = new DB(dbtyp, connstr, cmdtimeout);
            else
                db = new DB(dbtyp, ConnSecure.Decrypt(connstr), cmdtimeout);
            _conn = db.CreateConnection();
        }


        /// <summary>
        /// 紀錄歷程
        /// </summary>
        /// <param name="servicename">服務功能名稱</param>
        /// <param name="projectcode">專案名稱</param>
        /// <param name="userid">使用者Id</param>
        /// <param name="param"></param>
        public async void logHistory(string servicename, string projectcode, Guid userid, string param="")
        {
            await Task.Run(() =>
            {
                HistoryLog hl = new HistoryLog()
                {
                    Id = Guid.NewGuid(),
                    ServiceName = servicename,
                    ProjectCode = projectcode,
                    User_Id = userid,
                    ActionTime = DateTime.Now,
                    Params = param
                };
                TableEntity<HistoryLog> historyEntity = new TableEntity<HistoryLog>(DBType, DBConnStr, DBTimeout);
                historyEntity.Insert(hl);
            });
        }

    }
}
