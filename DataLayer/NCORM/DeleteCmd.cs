using NewCity.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;
using NewCity.DataAccess.Tools;
using System.Data;

namespace NewCity.DataAccess
{
    internal class DeleteCmd<T> where T : TableBase
    {
        private DBEntity _dbe;

        public IDbConnection Connection => _dbe.DBConnection;

        public DeleteCmd(DBEntity dBE)
        {
            _dbe = dBE;
        }

        public string GetDeleteCmd(T row)
        {
            var tabname = row.GetType().GetTableName();
            string sql = $"Delete from {_dbe.db.QuotedFieldName(tabname)} where Id={_dbe.db.QuotedValue(row.Id.ToString())};";
            return sql;
        }
    }
}
