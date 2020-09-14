using Dapper;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public async Task<IEnumerable<dynamic>> GetQueryResult(string sqlstr)
        {
            try
            {
                if (_dbe.DBType == DBType.MySql)
                    sqlstr = sqlstr.Replace("[", "`").Replace("]","`");
                var rst = await _dbe.DBConnection.QueryAsync(sqlstr, commandType: System.Data.CommandType.Text, transaction:globalTrans);
                return rst;
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"query: {sqlstr} occur error.");
                return null;
            }
            finally
            {
                if (globalTrans == null) _dbe.DBConnection.Close();
            }
        }

        /// <summary>
        /// 取得查詢的指定匿名型別
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetQueryResult<T>(string sqlstr)
        {
            try
            {
                if (_dbe.DBType == DBType.MySql)
                    sqlstr = sqlstr.Replace("[", "`").Replace("]", "`");
                var rst = await _dbe.DBConnection.QueryAsync<T>(sqlstr, commandType: System.Data.CommandType.Text, transaction: globalTrans);
                return rst;
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"query: {sqlstr} occur error.");
                return null;
            }
            finally
            {
                if (globalTrans == null) _dbe.DBConnection.Close();
            }
        }

        /// <summary>
        /// 取得多查詢的動態類別
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> GetManyQueryResult(IEnumerable<string> sqlstr)
        {
            SqlMapper.GridReader rst;
            try
            {
                string combinesql = "";
                if (_dbe.DBType == DBType.MySql)
                {
                    foreach (var s in sqlstr)
                        combinesql += s.Replace("[", "`").Replace("]", "`") + (s.EndsWith(";") ? "" : ";");
                }

                rst = _dbe.DBConnection.QueryMultipleAsync(combinesql, commandType: System.Data.CommandType.Text, transaction: globalTrans).Result;
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"query: {sqlstr} occur error.");
                yield break;
            }

            for (int i = 0; i < sqlstr.Count(); i++)
            {
                yield return rst.Read();
            }
            if (globalTrans == null) _dbe.DBConnection.Close();
        }

        /// <summary>
        /// 取得多查詢的動態類別
        /// </summary>
        /// <param name="sqlstr"></param>
        /// <returns></returns>
        public async IAsyncEnumerable<dynamic> GetManyQueryResultAsync(IEnumerable<string> sqlstr)
        {
            SqlMapper.GridReader rst;
            try
            {
                string combinesql = "";
                if (_dbe.DBType == DBType.MySql)
                {
                    foreach (var s in sqlstr)
                        combinesql += s.Replace("[", "`").Replace("]", "`") + (s.EndsWith(";") ? "" : ";");
                }

                rst = await _dbe.DBConnection.QueryMultipleAsync(combinesql, commandType: System.Data.CommandType.Text, transaction: globalTrans);
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"query: {sqlstr} occur error.");
                yield break;
            }

            for (int i = 0; i < sqlstr.Count(); i++)
            {
                yield return rst.Read();
            }
            if (globalTrans == null) _dbe.DBConnection.Close();
        }

        /// <summary>
        /// 呼叫預儲程序方法
        /// </summary>
        /// <param name="spname">程序名</param>
        /// <param name="param">參數</param>
        /// <returns>查詢的動態類別</returns>
        public async Task<dynamic> GetSPResult(string spname, object param)
        {
            try
            {
                var rst = await _dbe.DBConnection.QueryAsync(spname, param, commandType: System.Data.CommandType.StoredProcedure, transaction: globalTrans);
                return rst.AsList();
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"exec sp:{spname} occur error.");
                return null;
            }
            finally
            {
                if (globalTrans == null) _dbe.DBConnection.Close();
            }

        }

        /// <summary>
        /// 呼叫預儲程序方法
        /// </summary>
        /// <typeparam name="T">回傳型別</typeparam>
        /// <param name="spname">程序名</param>
        /// <param name="param">參數</param>
        /// <returns></returns>
        public async Task<IEnumerable<T>> GetSPResult<T>(string spname, object param)
        {
            try
            {
                var rst = await _dbe.DBConnection.QueryAsync<T>(spname, param, commandType: System.Data.CommandType.StoredProcedure, transaction: globalTrans);
                return rst;
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"exec sp:{spname} occur error.");
                return null;
            }
            finally
            {
                if (globalTrans == null) _dbe.DBConnection.Close();
            }

        }
    }
}
