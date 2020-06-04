using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NewCity.DataAccess
{
    internal class SelectCmd<T> where T : TableBase
    {
        private DBEntity _dbe;

        public IDbConnection Connection 
        { 
            get
            {
                if (_dbe.DBConnection.State == ConnectionState.Closed)
                    _dbe.DBConnection.Open();
                return _dbe.DBConnection;
            }       
        }
        public SelectCmd(DBEntity dBE) 
        {
            _dbe = dBE;
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
                {
                    if (pi.GetValue(row).ToString().StartsWith("%") || pi.GetValue(row).ToString().EndsWith("%"))
                        sbQry.AppendFormat("{0} like {1}", _dbe.db.QuotedFieldName(pi.Name), _dbe.db.QuotedValueByType(pi.GetValue(row).ToString(), pi));
                    else
                        sbQry.AppendFormat("{0}={1}", _dbe.db.QuotedFieldName(pi.Name), _dbe.db.QuotedValueByType(pi.GetValue(row).ToString(), pi));
                }
                else
                {
                    if (pi.GetValue(row).ToString().StartsWith("%") || pi.GetValue(row).ToString().EndsWith("%"))
                        sbQry.AppendFormat("and {0} like {1}", _dbe.db.QuotedFieldName(pi.Name), _dbe.db.QuotedValueByType(pi.GetValue(row).ToString(), pi));
                    else
                        sbQry.AppendFormat(" and {0}={1}", _dbe.db.QuotedFieldName(pi.Name), _dbe.db.QuotedValueByType(pi.GetValue(row).ToString(), pi));
                }
                    
            }

            var tabname = row.GetType().GetTableName();
            var sql = $"select * from {tabname} where {sbQry};";
            return sql;
        }
    }
}
