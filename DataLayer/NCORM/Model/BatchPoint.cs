using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///點數贈送
/// </summary>
public class BatchPoint : TableBase
{



///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///贈送日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///贈送原因
///[varchar(20), nullable(True)]
///</summary>
public string Code_FreePointReason { get; set; }

///<summary>
///生效日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///失效日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///來源TABLE
///[varchar(30), nullable(True)]
///</summary>
public string SourceTable { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }
}
}
