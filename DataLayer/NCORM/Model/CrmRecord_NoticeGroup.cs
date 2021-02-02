using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修登錄通知群組
/// </summary>
public class CrmRecord_NoticeGroup : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid RepairRecord_Id { get; set; }

///<summary>
///通知對象類別
///[varchar(20), nullable(True)]
///</summary>
public string Code_NoticeClass { get; set; }

///<summary>
///通知群組
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid NoticeGroup_Id { get; set; }
}
}
