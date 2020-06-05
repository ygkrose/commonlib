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
///</summary>
[Required]
public Guid ObjectTemp_Id { get; set; }

///<summary>
///代理人資料表Id
///</summary>
[Required]
public Guid Apply_Representative_Id { get; set; }

///<summary>
///授權起日
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///授權訖日
///</summary>
public DateTime? EndDate { get; set; }
}
}
