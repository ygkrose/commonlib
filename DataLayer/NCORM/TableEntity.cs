using Dapper;
using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Asn1.X509.Qualified;

namespace NewCity.DataAccess
{
    /// <summary>
    /// 資料表實體
    /// </summary>
    /// <typeparam name="T">資料表類別</typeparam>
    public class TableEntity<T> where T : TableBase
    {
        public DBEntity dbEntity;
        public IDbTransaction globalTrans { get; set; } = null;

        private int _cmdTimeout = 0;
        private string _connstr;
        private DBType _dBType;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="dbtyp">資料庫類別</param>
        /// <param name="connstr">連線字串</param>
        /// <param name="cmdtimeout">逾時設定</param>
        public TableEntity(DBType dbtyp,string connstr, int cmdtimeout = 30)
        {
            _cmdTimeout = cmdtimeout;
            _connstr = connstr;
            _dBType = dbtyp;
            dbEntity = new DBEntity(dbtyp, connstr, cmdtimeout);
        }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="dbe">資料庫實體</param>
        public TableEntity(DBEntity dbe, IDbTransaction transaction=null)
        {
            _cmdTimeout = dbe.DBTimeout;
            _connstr = dbe.DBConnStr;
            _dBType = dbe.DBType;
            dbEntity = dbe;
            this.globalTrans = transaction;
        }

        public List<T> Select(T rowdata)
        {
            SelectCmd<T> cmd = new SelectCmd<T>(dbEntity);
            var aloneconn = dbEntity.db.CreateConnection();
            var trans = aloneconn.BeginTransaction(IsolationLevel.ReadUncommitted);
            string sql = cmd.GetSelectCmd(rowdata);
            try
            {
                var rtn = aloneconn.Query<T>(sql, transaction: trans);
                trans.Commit();
                return rtn.ToList();
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"select commands occur error.");
                throw err;
            }
            finally
            {
                aloneconn.Close();
            }
        }


        public bool Exist(T rowdata)
        {
            var rtnRow = Select(rowdata);
            return (rtnRow.Count > 0);
        }

        public static explicit operator TableEntity<T>(TableEntity<TableBase> v)
        {
            return new TableEntity<T>(v._dBType, v._connstr, v._cmdTimeout);
        }

        /// <summary>
        /// 刪除資料列
        /// </summary>
        /// <param name="rowdata"></param>
        /// <returns></returns>
        public bool Delete(T rowdata)
        {
            DeleteCmd<T> cmd = new DeleteCmd<T>(dbEntity);
            string sql = cmd.GetDeleteCmd(rowdata);
            if (string.IsNullOrEmpty(sql))
            {
                return false;
            }
            try
            {
                CommandDefinition cd = new CommandDefinition(commandText:sql, commandTimeout:_cmdTimeout, transaction: globalTrans);
                cmd.Connection.Execute(sql);
                return true;
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"delete row from {rowdata.GetType().Name} occur error.");
                return false;
            }
            finally
            {
                if (globalTrans == null) cmd.Connection.Close();
            }
            
        }

        /// <summary>
        /// 刪除資料集
        /// </summary>
        /// <param name="rowdata"></param>
        /// <returns></returns>
        public bool Delete(List<T> rowdata)
        {
            DeleteCmd<T> cmd = new DeleteCmd<T>(dbEntity);
            IDbTransaction trans = globalTrans?? cmd.Connection.BeginTransaction();
            StringBuilder sql = new StringBuilder();
            foreach (T row in rowdata)
            {
                sql.Append(cmd.GetDeleteCmd(row));
            }
            if (string.IsNullOrEmpty(sql.ToString()))
            {
                return false;
            }
            try
            {
                CommandDefinition cd = new CommandDefinition(commandText: sql.ToString(), transaction: trans, commandTimeout: _cmdTimeout);
                cmd.Connection.Execute(cd);
                if (globalTrans == null)
                    trans.Commit();
                return true;
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"delete rows from {rowdata.GetType().Name} occur error.");
                if (globalTrans==null) trans.Rollback();
                return false;
            }
            finally
            {
                if (globalTrans == null)
                {
                    trans.Dispose();
                    cmd.Connection.Close();
                }
            }

        }

        /// <summary>
        /// 新增資料列
        /// </summary>
        /// <param name="rowdata"></param>
        /// <returns></returns>
        public bool Insert(T rowdata)
        {
            InsertCmd<T> cmd = new InsertCmd<T>(dbEntity);

            try
            {
                
                var str = cmd.GetInsertCmd(rowdata);
                if (string.IsNullOrEmpty(str))
                {
                    return false;
                }
                try
                {
                    CommandDefinition cd = new CommandDefinition(commandText: str.ToString(),transaction: globalTrans, commandTimeout: _cmdTimeout);
                    cmd.Connection.Execute(cd);
                    return true;
                }
                catch (Exception err)
                {
                    ErrLog.ExceptionLog(err, $"insert row into {rowdata.GetType().Name} occur error.");
                    throw err;
                }
                finally
                {
                    if (globalTrans == null)  cmd.Connection.Close();
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }

        /// <summary>
        /// 新增資料集
        /// </summary>
        /// <param name="rowdata"></param>
        /// <returns></returns>
        public bool Insert(List<T> rowdata)
        {
            InsertCmd<T> cmd = new InsertCmd<T>(dbEntity);

            IDbTransaction trans = globalTrans?? cmd.Connection.BeginTransaction();
            try
            {
                string str = "";
                foreach (T row in rowdata)
                {
                    str += cmd.GetInsertCmd(row);
                }
                if (string.IsNullOrEmpty(str))
                {
                    return false;
                }
                try
                {
                    CommandDefinition cd = new CommandDefinition(commandText: str.ToString(), transaction: trans, commandTimeout: _cmdTimeout);
                    cmd.Connection.Execute(cd);
                    if (globalTrans == null) trans.Commit();
                    return true;
                }
                catch (Exception err)
                {
                    ErrLog.ExceptionLog(err, $"insert rows to table {rowdata.GetType().Name} occur error.");
                    if (globalTrans == null) trans.Rollback();
                    throw err;
                }
                finally
                {
                    if (globalTrans == null)
                    {
                        trans.Dispose();
                        cmd.Connection.Close();
                    }
                }
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"insert commands occur error.");
                throw err;
            }
        }

        /// <summary>
        /// 更新資料列
        /// </summary>
        /// <param name="rowdata"></param>
        /// <returns></returns>
        public int Update(T rowdata)
        {
            UpdateCmd<T> cmd = new UpdateCmd<T>(dbEntity);
            try
            {
                var str = cmd.GetUpdateCmd(rowdata);
                if (string.IsNullOrEmpty(str))
                {
                    return -1;
                }
                try
                {
                    CommandDefinition cd = new CommandDefinition(commandText: str.ToString(), transaction: globalTrans, commandTimeout: _cmdTimeout);
                    var row = cmd.Connection.Execute(cd);
                    return row;
                }
                catch (Exception err)
                {
                    ErrLog.ExceptionLog(err, $"update table {rowdata.GetType().Name} occur error.");
                    throw err;
                }
                finally
                {
                    if (globalTrans == null) cmd.Connection.Close();
                }
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"update command occur error.");
                throw err;
            }
        }

        /// <summary>
        /// 更新資料集
        /// </summary>
        /// <param name="rowdata"></param>
        /// <returns></returns>
        public bool Update(List<T> rowdata)
        {
            UpdateCmd<T> cmd = new UpdateCmd<T>(dbEntity);
            IDbTransaction trans = globalTrans?? cmd.Connection.BeginTransaction();
            try
            {
                string str = "";
                foreach (T row in rowdata)
                {
                    str += cmd.GetUpdateCmd(row) ;
                }
                if (string.IsNullOrEmpty(str))
                {
                    return false;
                }
                try
                {
                    CommandDefinition cd = new CommandDefinition(commandText: str.ToString(), transaction: trans, commandTimeout: _cmdTimeout);
                    cmd.Connection.Execute(cd);
                    if (globalTrans == null) trans.Commit();
                    return true;
                }
                catch (Exception err)
                {
                    ErrLog.ExceptionLog(err, $"update rows to table {rowdata.GetType().Name} occur error.");
                    if (globalTrans == null) trans.Rollback();
                    throw err;
                }
                finally
                {
                    if (globalTrans == null)
                    {
                        trans.Dispose();
                        cmd.Connection.Close();
                    }
                    
                }
            }
            catch (Exception err)
            {
                ErrLog.ExceptionLog(err, $"update commands occur error.");
                throw err;
            }
        }
        
    }
}
