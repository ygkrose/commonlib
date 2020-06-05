using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///申請物件代理人身檔
/// </summary>
public class ObjectTemp_Representative : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///代理人資料表Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Apply_Representative_Id { get; set; }

///<summary>
///授權起日
///[datetime, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///授權訖日
///[datetime, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }
}
}
