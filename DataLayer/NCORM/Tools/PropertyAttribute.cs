using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewCity.DataAccess.Tools
{
    public static class PropertyAttribute
    {
        public static T GetAttributeFrom<T>(this PropertyInfo instance, string propertyName) where T : Attribute
        {
            var attrType = typeof(T);
            var property = instance.GetType().GetProperty(propertyName);
            return (T)property.GetCustomAttributes(attrType, false).First();
        }

        public static string GetTableName(this Type type)
        {
            string tableName = string.Empty;
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                if (attr is TableAttribute)
                {
                    TableAttribute tableAttribute = attr as TableAttribute;
                    tableName = tableAttribute.Name;
                }
            }
            if (string.IsNullOrEmpty(tableName))
            {
                var curr = type.Name;
                while (type.BaseType.Name != "TableBase")
                {
                    type = type.BaseType;
                    if (type.Name == curr)
                        break;
                }
                tableName = type.Name;
            }
            return tableName;
        }

        /// <summary>  
        /// 獲取字段名  
        /// </summary>  
        /// <param name="property"></param>  
        /// <returns></returns>  
        public static string GetColumnName(PropertyInfo property)
        {
            string columnName = string.Empty;
            object[] attributes = property.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                if (attr is ColumnAttribute)
                {
                    ColumnAttribute columnAttr = attr as ColumnAttribute;
                    columnName = columnAttr.Name;
                }
            }
            if (string.IsNullOrEmpty(columnName))
            {
                columnName = property.Name;
            }
            return columnName;
        }

        /// <summary>  
        /// 判斷主鍵是否自增  
        /// </summary>  
        /// <param name="property"></param>  
        /// <returns></returns>  
        public static bool IsIncrement(Type type)
        {
            object[] attributes = type.GetCustomAttributes(false);
            //foreach (var attr in attributes)
            //{
            //    if (attr is PrimaryKeyAttribute)
            //    {
            //        PrimaryKeyAttribute primaryKeyAttr = attr as PrimaryKeyAttribute;
            //        return primaryKeyAttr.autoIncrement;
            //    }
            //}
            return false;
        }

        /// <summary>  
        /// 獲取主鍵名  
        /// </summary>  
        /// <param name="type"></param>  
        /// <returns></returns>  
        public static string GetPrimary(Type type)
        {
            object[] attributes = type.GetCustomAttributes(false);
            foreach (var attr in attributes)
            {
                //if (attr is PrimaryKeyAttribute)
                //{
                //    PrimaryKeyAttribute primaryKeyAttr = attr as PrimaryKeyAttribute;
                //    return primaryKeyAttr.Value;
                //}
            }
            return null;
        }

        /// <summary>  
        /// 判斷屬性是否為主鍵  
        /// </summary>  
        /// <param name="type"></param>  
        /// <param name="property"></param>  
        /// <returns></returns>  
        public static bool IsPrimary(Type type, PropertyInfo property)
        {
            string primaryKeyName = GetPrimary(type);
            string columnName = GetColumnName(property);
            return (primaryKeyName == columnName);
        }
    }
}
