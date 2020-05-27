using System;
using System.Collections.Generic;
using System.Text;

namespace NewCity.Common
{
    /// <summary>
    /// 時間格式轉換的擴充類別
    /// </summary>
    public static class NCDatetime 
    {
        private const string FORMAT_DATE_WITHOUT_SEPARATOR = "yyyyMMdd";
        private const string FORMAT_DATETIME_WITHOUT_SEPARATOR = FORMAT_DATE_WITHOUT_SEPARATOR + "HHmmss";
        //private const string FORMAT_TIMESTAMP = FORMAT_DATETIME_WITHOUT_SEPARATOR;
        //private const string FORMAT_LONGTIMESTAMP = FORMAT_DATETIME_WITHOUT_SEPARATOR + "fff";
        private const string FORMAT_DATE = "yyyy/MM/dd";
        private const string FORMAT_DATE_DASH_SEPARATOR = "yyyy-MM-dd";
        private const string FORMAT_DATETIME = FORMAT_DATE + " HH:mm:ss";
        private const string FORMAT_DATETIME_WITH_MILISENOND = FORMAT_DATETIME + ".fff";
        /// <summary>
        ///return  yyyyMMdd
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_DATE_WITHOUT_SEPARATOR(this DateTime dt)
        {
            return dt.ToString(FORMAT_DATE_WITHOUT_SEPARATOR);
        }

        /// <summary>
        /// return yyyyMMddHHmmss 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_DATETIME_WITHOUT_SEPARATOR(this DateTime dt)
        {
            return dt.ToString(FORMAT_DATETIME_WITHOUT_SEPARATOR);
        }

        /// <summary>
        /// return TimeStamp String 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_TIMESTAMP(this DateTime dt)
        {
            int timeStamp = Convert.ToInt32(dt.Subtract(new DateTime(1970, 1, 1)).TotalSeconds);
            return dt.ToString(timeStamp.ToString());
        }
        /// <summary>
        /// return LongTimeStamp String 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_LONGTIMESTAMP(this DateTime dt)
        {
            double timeStamp = dt.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            return dt.ToString(timeStamp.ToString().Replace(".",""));
        }

        /// <summary>
        /// return yyyy/MM/dd
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_DATE(this DateTime dt)
        {
            return dt.ToString(FORMAT_DATE);
        }

        /// <summary>
        /// return yyyy-MM-dd 
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_DATE_DASH_SEPARATOR(this DateTime dt)
        {
            return dt.ToString(FORMAT_DATE_DASH_SEPARATOR);
        }
        /// <summary>
        /// return yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_DATETIME_DASH_SEPARATOR(this DateTime dt)
        {
            return dt.ToString(FORMAT_DATE_DASH_SEPARATOR + " HH:mm:ss");
        }
        /// <summary>
        /// return yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_DATETIME(this DateTime dt)
        {
            return dt.ToString(FORMAT_DATETIME);
        }

        /// <summary>
        ///  return yyyy/MM/dd HH:mm:ss.sss
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        public static string NC_FORMAT_DATETIME_WITH_MILISENOND(this DateTime dt)
        {
            return dt.ToString(FORMAT_DATETIME_WITH_MILISENOND);
        }
    }
}
