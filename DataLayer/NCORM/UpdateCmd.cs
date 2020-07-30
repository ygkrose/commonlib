using NewCity.DataAccess.Model;
using NewCity.DataAccess.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace NewCity.DataAccess
{
    internal class UpdateCmd<T> where T : TableBase
    {
        private DBEntity _dbe;

        public IDbConnection Connection => _dbe.DBConnection;
        public UpdateCmd(DBEntity dBE)
        {
            _dbe = dBE;
        }

    public string GetUpdateCmd(T row)
        {
            int ctr = 0;
            Type type = row.GetType();
            //Type type = typeof(T);
            StringBuilder sbQry = new StringBuilder();
            System.Reflection.PropertyInfo[] propInfo = type.GetProperties();
            string _keyCol = "";
            try
            {
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
                                 _dbe.db.QuotedFieldName(tabname), _dbe.db.QuotedFieldName(pi.Name), _dbe.db.QuotedValueByType(_value.ToString(), pi));
                    }
                    else
                        sbQry.AppendFormat(", {0}={1}", _dbe.db.QuotedFieldName(pi.Name), _dbe.db.QuotedValueByType(_value.ToString(), pi));

                    ctr++;
                }

                if (sbQry.ToString() != string.Empty)
                {
                    //sbQry.AppendFormat(" Where {0}={1} ", propInfo[0].Name, "[" + ctr + "]");
                    sbQry.AppendFormat($" Where {_keyCol} ='{propInfo.Where((x) => x.Name == _keyCol).FirstOrDefault().GetValue(row)}';");
                }
            }
            catch (Exception err)
            {
                throw err;
            }

            //sbQry.Replace("[", "{").Replace("]", "}");

            return sbQry.ToString();
        }
    }
}
