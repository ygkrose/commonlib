using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修項目設定廠商明細
/// </summary>
public class CheckCrmSetting_Supplier : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckCrmSetting_Id { get; set; }

///<summary>
///廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///通知群組
///[char(36), nullable(True)]
///</summary>
public Guid? NoticeGroup_Id { get; set; }

///<summary>
///可維修星期(1,2,3,4,5)
///[varchar(10), nullable(True)]
///</summary>
public string Weekday { get; set; }

///<summary>
///可維修時間起
///[time, nullable(True)]
///</summary>
public TimeSpan StartTime { get; set; }

///<summary>
///可維修時間訖
///[time, nullable(True)]
///</summary>
public TimeSpan EndTime { get; set; }
}
}
