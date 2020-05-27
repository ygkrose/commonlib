using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewCity.DataAccess
{
    internal class SelectCmd<T> : DB where T : TableBase
    {
        public SelectCmd(DBType dbtype, string connstr, int cmdtimeout = 30) : base(dbtype, connstr, cmdtimeout)
        {
        }


        public string GetSelectCmd(T row)
        {
            Type type = row.GetType();
            //Type type = typeof(T);
            StringBuilder sbQry = new StringBuilder();
            System.Reflection.PropertyInfo[] propInfo = type.GetProperties();

            foreach (System.Reflection.PropertyInfo pi in propInfo)
            {
                if (pi.GetValue(row) == null) continue;

                if (pi.PropertyType == typeof(DateTime) && Convert.ToDateTime(pi.GetValue(row)).Year == 1)
                {
                    continue;
                }
                if (pi.GetValue(row).ToString() == "00000000-0000-0000-0000-000000000000")
                {
                    continue;
                }

                if (sbQry.ToString() == string.Empty)
                    sbQry.AppendFormat("{0}={1}", base.QuotedFieldName(pi.Name), base.QuotedValueByType(pi.GetValue(row).ToString(), pi));
                else
                    sbQry.AppendFormat(" and {0}={1}", base.QuotedFieldName(pi.Name), base.QuotedValueByType(pi.GetValue(row).ToString(), pi));
            }

            var tabname = row.GetType().GetTableName();
            var sql = $"select * from {tabname} where {sbQry};";
            return sql;
        }
    }
}
