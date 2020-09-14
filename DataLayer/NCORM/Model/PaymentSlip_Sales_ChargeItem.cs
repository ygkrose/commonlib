using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///繳款單號帳款檔
/// </summary>
public class PaymentSlip_Sales_ChargeItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid PaymentSlip_Id { get; set; }

///<summary>
///銷帳項目明細Id
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
