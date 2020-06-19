using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace NewCity.DataAccess.Model
{
/// <summary>
///程式存取紀錄檔
/// </summary>
public class HistoryLog : TableBase
{

        [IgnoreDataMember]
        public override Guid Id { get => base.Id; set => base.Id = value; }
        ///<summary>
        ///服務名稱
        ///[varchar(100), nullable(True)]
        ///</summary>
        public string ServiceName { get; set; }

///<summary>
///專案名稱
///[varchar(100), nullable(True)]
///</summary>
public string ProjectCode { get; set; }

///<summary>
///使用者Id
///[char(36), nullable(True)]
///</summary>
public Guid? User_Id { get; set; }

///<summary>
///執行時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ActionTime { get; set; }
}
}
