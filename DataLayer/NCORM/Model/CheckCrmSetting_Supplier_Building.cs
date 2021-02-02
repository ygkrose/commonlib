using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修廠商服務大樓明細
/// </summary>
public class CheckCrmSetting_Supplier_Building : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CheckCrmSetting_Supplier_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///通知群組
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid NoticeGroup_Id { get; set; }
}
}
