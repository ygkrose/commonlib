using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;

namespace NewCity.DataAccess
{
    internal class InsertCmd<T>  where T : TableBase
    {
        private DBEntity _dbe;

        public IDbConnection Connection => _dbe.DBConnection;
        public InsertCmd(DBEntity dBE)
        {
            _dbe = dBE;
        }

        public string GetInsertCmd(T row)
        {
            
            StringBuilder sb = new StringBuilder();
            //int ctr = 0;
            Type type = row.GetType();
            //Type type = typeof(T);
            StringBuilder sbQry = new StringBuilder();
            System.Reflection.PropertyInfo[] propInfo = type.GetProperties();
            try
            {
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
                           _dbe.db.QuotedFieldName(tabname), _dbe.db.QuotedFieldName(pi.Name));
                    }
                    else
                    {
                        sbQry.AppendFormat(", {0}", _dbe.db.QuotedFieldName(pi.Name));
                        sb.Append(",");
                    }

                    sb.Append(_dbe.db.QuotedValueByType(pi.GetValue(row).ToString(), pi));
                }

                if (sbQry.ToString() != string.Empty)
                    sbQry.AppendFormat(") VALUES({0});", sb.ToString());
            }
            catch (Exception err)
            {
                throw err;
            }
            return sbQry.ToString();
        }
    }
}
