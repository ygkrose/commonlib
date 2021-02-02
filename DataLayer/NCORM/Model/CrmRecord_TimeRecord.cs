using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修登錄時間紀錄
/// </summary>
public class CrmRecord_TimeRecord : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CrmRecord_Id { get; set; }

///<summary>
///時間紀錄類別(assignbefore物管派案時限,assign派案時間,arrivebefore廠商到達時限,donebefore廠商完成時限,read廠商讀取,arrive廠商到達,done廠商處理完成,reviewbefore物管驗收時限,close結案)
///[varchar(20), nullable(True)]
///</summary>
public string Code_RepairTimeType { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
