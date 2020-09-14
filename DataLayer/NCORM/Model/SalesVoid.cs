using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///銷貨作廢
/// </summary>
public class SalesVoid : TableBase
{



///<summary>
///日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///作廢單號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Sales_ChargeItem_Id { get; set; }

///<summary>
///作廢原因
///[varchar(20), nullable(True)]
///</summary>
public string Code_VoidReason { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

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

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
