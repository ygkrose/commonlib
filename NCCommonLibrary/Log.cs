using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;

namespace NewCity.Common
{


    public class NCLog
    {
        private static string LogDateTimeStr()
        {
            return DateTime.Now.NC_FORMAT_DATETIME();
        } 

        public static void ExceptionLog(Exception e, string extMsg = "")
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Error");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            path = Path.Combine(path, DateTime.Now.NC_FORMAT_DATE_WITHOUT_SEPARATOR() + ".txt");

            List<string> txt = new List<string>();
            txt.Add(">>>" + LogDateTimeStr());
            txt.Add($"   執行緒編號：{Thread.CurrentThread.ManagedThreadId}");
            txt.Add($"   錯誤訊息：{e.Message}");
            txt.Add($"   錯誤位置：{e.StackTrace}");
            txt.Add($"   原始位置：{e.TargetSite}");
            if (extMsg != "") txt.Add($"   額外訊息：{extMsg}");
            if (e.InnerException != null)
            {
                txt.Add($"內部錯誤信息：{e.InnerException.Message}");
                txt.Add($"內部錯誤位置: {e.InnerException.StackTrace}");
            }

            System.IO.File.AppendAllLines(path, txt);
        }

        public static void InfomationLog(params string[] txts)
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            path = Path.Combine(path, DateTime.Now.NC_FORMAT_DATE_DASH_SEPARATOR() + ".txt");
            System.IO.File.AppendAllLines(path, txts);
        }
    }
}
