using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收款銷帳折扣檔
/// </summary>
public class PaymentRecord_Coupon : TableBase
{



///<summary>
///收款銷帳沖帳身檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Offset_WriteOffD_Id { get; set; }

///<summary>
///優惠券ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Coupon_Id { get; set; }

///<summary>
///折扣金額
///[double, nullable(False)]
///</summary>
[Required]
public Double Discount { get; set; }
}
}
