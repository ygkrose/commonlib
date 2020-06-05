using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace NewCity.DataAccess.Tools
{
    public class ErrLog
    {
        public static void ExceptionLog(Exception e, string extMsg = "")
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NCORMError");
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);
            path = Path.Combine(path, DateTime.Now.ToString("yyyyMMdd") + ".txt");

            List<string> txt = new List<string>();
            txt.Add(">>>" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"));
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
    }
}
