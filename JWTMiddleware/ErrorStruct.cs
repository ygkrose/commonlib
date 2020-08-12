using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace JWTMiddleware
{
   
    public static class ErrorStruct
    {
        /// <summary>
        /// API的服務ID，唯一值，公司統一分配
        /// 錯誤碼前三碼(ServiceID)編碼原則：
        /// 100~199 基礎API(DB連線，驗證服務，檔案傳輸....)
        /// 200~499 中間層(個別資料表的CRUD服務)
        /// 500~799 提供服務層(組合中間層)
        /// 800~999 前端程式
        /// </summary>
        public static string ServiceID = "150";

        /// <summary>
        /// 錯誤碼(固定三碼)及回傳訊息
        /// </summary>
        public enum ErrorNum : Int16
        {
            [Description("Token invalid:")]
            token_invalid = 900,
            [Description("Token update error:")]
            update_token_error = 901,
            [Description("Write cache error:")]
            cache_error = 902,
            [Description("Token refresh error:")]
            refresh_token_error = 903,
            [Description("Token expired:")]
            token_expired = 904,
            [Description("Undefined error:")]
            error_undefined = 999
        }

        /// <summary>
        /// 輸出錯誤描述與額外訊息
        /// </summary>
        /// <param name="value">錯誤列舉值</param>
        /// <param name="extramsg">額外訊息</param>
        /// <returns></returns>
        public static dynamic GetErrReturn(this Enum value, string extramsg = "")
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return new { ErrorCode = ServiceID + (int)((ErrorNum)value), ErrorMessage = attr.Description + extramsg, ErrorTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") };
                    }
                }
            }
            return null;
        }
    }
}
