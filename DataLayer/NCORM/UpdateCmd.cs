using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewCity.DataAccess
{
    internal class UpdateCmd<T> : DB where T : TableBase
    {
        public UpdateCmd(DBType dbtype, string connstr, int cmdtimeout = 30) : base(dbtype, connstr, cmdtimeout)
        {
        }

        public string GetUpdateCmd(T row)
        {
            int ctr = 0;
            Type type = row.GetType();
            //Type type = typeof(T);
            StringBuilder sbQry = new StringBuilder();
            System.Reflection.PropertyInfo[] propInfo = type.GetProperties();
            string _keyCol = "";
            foreach (System.Reflection.PropertyInfo pi in propInfo)
            {
                var _value = pi.GetValue(row);
                
                if (pi.PropertyType == typeof(DateTime) && Convert.ToDateTime(_value).Year == 1)
                    continue;
                if (pi.GetCustomAttributesData().Select((x) => x.AttributeType.Name).Contains("KeyAttribute"))
                {
                    if (_value == null || _value.ToString() == "00000000-0000-0000-0000-000000000000")
                    {
                        throw new Exception("can't update row without key value");
                    }
                    _keyCol = pi.Name;
                    continue;
                }

                if (_value == null)
                    continue;


                if (sbQry.ToString() == string.Empty)
                {
                    var tabname = type.GetTableName();
                    sbQry.AppendFormat("Update {0} Set {1}={2}",
                             base.QuotedFieldName(tabname), base.QuotedFieldName(pi.Name), base.QuotedValueByType(_value.ToString(), pi));
                }
                else
                    sbQry.AppendFormat(", {0}={1}", base.QuotedFieldName(pi.Name), base.QuotedValueByType(_value.ToString(), pi));

                ctr++;
            }

            if (sbQry.ToString() != string.Empty)
            {
                //sbQry.AppendFormat(" Where {0}={1} ", propInfo[0].Name, "[" + ctr + "]");
                sbQry.AppendFormat($" Where {_keyCol} ='{propInfo.Where((x) => x.Name == _keyCol).FirstOrDefault().GetValue(row)}';");
            }


            //sbQry.Replace("[", "{").Replace("]", "}");

            return sbQry.ToString();
        }
    }
}
