using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///移轉作業銷貨明細
/// </summary>
public class Transfer_SalesChargeItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Transfer_Id { get; set; }

///<summary>
///銷貨明細ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Sales_ChargeItem_Id { get; set; }

///<summary>
///金額
///[double, nullable(False)]
///</summary>
[Required]
public Double? Amount { get; set; }
}
}
