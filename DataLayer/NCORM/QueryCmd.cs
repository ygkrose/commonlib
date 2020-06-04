using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewCity.DataAccess
{
    /// <summary>
    /// 直接查詢DB類別
    /// </summary>
    public class QueryCmd 
    {
        private DB _DB;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dBType">資料庫類別</param>
        /// <param name="conn">連線字串</param>
        /// <param name="cmdtimeout">逾時設定</param>
        public QueryCmd(DBType dBType,string conn,int cmdtimeout=30)
        {
            _DB = new DB(dBType, conn, cmdtimeout);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dbe">DB Entity</param>
        public QueryCmd(DBEntity dbe)
        {
            _DB = new DB(dbe.DBType, dbe.DBConnStr, dbe.DBTimeout);
        }

        /// <summary>
        /// 取得查詢的動態類別
        /// </summary>
        /// <param name="sqlstr">sql語法</param>
        /// <returns></returns>
        public async Task<dynamic> GetQueryResult(string sqlstr)
        {
            try
            {
                var rst = await _DB.Connection.QueryAsync(sqlstr, commandType: System.Data.CommandType.Text);
                return rst.AsList();
            }
            catch (Exception err)
            {
                //NCLog.ExceptionLog(err, $"query: {sqlstr} occur error.");
                throw err;
            }
            finally
            {
                _DB.Connection.Close();
            }
        }

        /// <summary>
        /// 呼叫與除程序方法
        /// </summary>
        /// <param name="spname">程序名</param>
        /// <param name="param">參數</param>
        /// <returns>查詢的動態類別</returns>
        public async Task<dynamic> GetSPResult(string spname, object param)
        {
            try
            {
                var rst = await _DB.Connection.QueryAsync(spname, param, commandType: System.Data.CommandType.StoredProcedure);
                return rst.AsList();
            }
            catch (Exception err)
            {
                //NCLog.ExceptionLog(err, $"exec sp:{spname} occur error.");
                throw err;
            }
            finally
            {
                _DB.Connection.Close();
            }

        }
    }
}
