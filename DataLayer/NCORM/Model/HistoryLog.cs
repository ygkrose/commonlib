using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace NewCity.DataAccess.Model
{
    /// <summary>
    /// 歷程檔資料表類別
    /// </summary>
    public class HistoryLog : TableBase
    {
        [IgnoreDataMember]
        public override Guid Id { get => base.Id; set => base.Id = value; }
        ///<summary>
        ///服務名稱
        ///</summary>
        public string ServiceName { get; set; }

        ///<summary>
        ///專案名稱
        ///</summary>
        public string ProjectCode { get; set; }

        ///<summary>
        ///使用者Id
        ///</summary>
        public Guid? User_Id { get; set; }

        ///<summary>
        ///執行時間
        ///</summary>
        public DateTime? ActionTime { get; set; }
    }
}
