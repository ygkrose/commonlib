using Dapper;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace NewCity.DataAccess
{
    /// <summary>
    /// 直接查詢DB類別
    /// </summary>
    public class QueryCmd 
    {
        public IDbTransaction globalTrans { get; set; } = null;

        private DB _DB;
        private DBEntity _dbe;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="dBType">資料庫類別</param>
        /// <param name="conn">連線字串</param>
        /// <param name="cmdtimeout">逾時設定</param>
        public QueryCmd(DBType dBType,string conn,int cmdtimeout=30)
        {
            //_DB = new DB(dBType, conn, cmdtimeout);
            _dbe = new DBEntity(dBType, conn, cmdtimeout);
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="dbe">DB Entity</param>
        public QueryCmd(DBEntity dbe, IDbTransaction transaction = null)
        {
            //_DB = new DB(dbe.DBType, dbe.DBConnStr, dbe.DBTimeout);
            _dbe = dbe;
            this.globalTrans = transaction;
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
                var rst = await _dbe.DBConnection.QueryAsync(sqlstr, commandType: System.Data.CommandType.Text, transaction:globalTrans);
                if (globalTrans == null) globalTrans.Commit();
                return rst.AsList();
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"query: {sqlstr} occur error.");
                if (globalTrans == null) globalTrans.Rollback();
                return null;
            }
            finally
            {
                if (globalTrans == null) _dbe.DBConnection.Close();
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
                var rst = await _dbe.DBConnection.QueryAsync(spname, param, commandType: System.Data.CommandType.StoredProcedure, transaction: globalTrans);
                if (globalTrans == null) globalTrans.Commit();
                return rst.AsList();
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"exec sp:{spname} occur error.");
                if (globalTrans == null) globalTrans.Rollback();
                return null;
            }
            finally
            {
                if (globalTrans == null) _dbe.DBConnection.Close();
            }

        }
    }
}
