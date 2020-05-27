using NewCity.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Text;
using NewCity.DataAccess.Tools;

namespace NewCity.DataAccess
{
    internal class DeleteCmd<T> : DB where T : TableBase
    {
        public DeleteCmd(DBType dbtype, string connstr, int cmdtimeout = 30) : base(dbtype, connstr, cmdtimeout)
        {
        }

        public string GetDeleteCmd(T row)
        {
            var tabname = row.GetType().GetTableName();
            string sql = $"Delete from {base.QuotedFieldName(tabname)} where Id={base.QuotedValue(row.Id.ToString())};";
            return sql;
        }
    }
}
