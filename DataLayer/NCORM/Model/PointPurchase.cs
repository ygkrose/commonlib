using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///點數購買
/// </summary>
public class PointPurchase : TableBase
{



///<summary>
///日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///購買金額
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Amount { get; set; }

///<summary>
///已收現金
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Cash { get; set; }

///<summary>
///收入項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }

///<summary>
///點數類別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PointTerm { get; set; }

///<summary>
///點數
///[double, nullable(False)]
///</summary>
[Required]
public Double? Point { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
