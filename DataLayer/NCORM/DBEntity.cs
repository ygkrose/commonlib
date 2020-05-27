using NewCity.DataAccess.Model;
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

        public IDbConnection DBConnection { get; set; }
        private DB db;
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
            db = new DB(dbtyp, connstr, cmdtimeout);
            DBConnection = db.Connection;
        }

        /// <summary>
        /// 紀錄歷程
        /// </summary>
        /// <param name="servicename">服務功能名稱</param>
        /// <param name="projectcode">專案名稱</param>
        /// <param name="userid">使用者Id</param>
        public async void logHistory(string servicename, string projectcode, Guid userid)
        {
            await Task.Run(() =>
            {
                HistoryLog hl = new HistoryLog()
                {
                    ServiceName = servicename,
                    ProjectCode = projectcode,
                    User_Id = userid,
                    ActionTime = DateTime.Now
                };
                TableEntity<HistoryLog> historyEntity = new TableEntity<HistoryLog>(DBType, DBConnStr, DBTimeout);
                historyEntity.Insert(hl);
            });
        }

    }
}
