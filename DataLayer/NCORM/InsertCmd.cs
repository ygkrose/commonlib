using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace NewCity.DataAccess
{
    internal class InsertCmd<T> : DB where T : TableBase
    {
        public InsertCmd(DBType dbtype, string connstr, int cmdtimeout = 30) : base(dbtype, connstr, cmdtimeout)
        {
        }

        public string GetInsertCmd(T row)
        {
            StringBuilder sb = new StringBuilder();
            //int ctr = 0;
            Type type = row.GetType();
            //Type type = typeof(T);
            StringBuilder sbQry = new StringBuilder();
            System.Reflection.PropertyInfo[] propInfo = type.GetProperties();
            foreach (System.Reflection.PropertyInfo pi in propInfo)
            {
                if (pi.GetCustomAttributesData().Select((x) => x.AttributeType.Name).Contains("RequiredAttribute"))
                {
                    if (pi.GetValue(row) == null)
                        throw new Exception($"{pi.Name} value required");
                    if (pi.PropertyType == typeof(DateTime) && Convert.ToDateTime(pi.GetValue(row)).Year == 1)
                        throw new Exception($"{pi.Name} value required");
                }
                if (pi.GetCustomAttributesData().Select((x) => x.AttributeType.Name).Contains("IgnoreDataMemberAttribute") ||
                    pi.GetValue(row) == null)
                {
                    continue;
                }


                if (sbQry.ToString() == string.Empty)
                {
                    var tabname = type.GetTableName();
                    //var tabname = type.GetCustomAttributes(typeof(TableAttribute), false);
                    sbQry.AppendFormat("INSERT INTO {0} ({1}",
                       base.QuotedFieldName(tabname), base.QuotedFieldName(pi.Name));
                }
                else
                {
                    sbQry.AppendFormat(", {0}", base.QuotedFieldName(pi.Name));
                    sb.Append(",");
                }

                sb.Append(base.QuotedValueByType(pi.GetValue(row).ToString(), pi));
            }

            if (sbQry.ToString() != string.Empty)
                sbQry.AppendFormat(") VALUES({0});", sb.ToString());

            return sbQry.ToString();
        }
    }
}
