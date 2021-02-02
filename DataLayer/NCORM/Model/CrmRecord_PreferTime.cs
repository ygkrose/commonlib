using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修登錄希望處理時間
/// </summary>
public class CrmRecord_PreferTime : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CrmRecord_Id { get; set; }

///<summary>
///順序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///日期時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }
}
}
