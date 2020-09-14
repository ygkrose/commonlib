using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///繳款單號預繳優惠方案檔
/// </summary>
public class PaymentSlip_Advanced_CouponSetting : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(True)]
///</summary>
public Guid? PaymentSlip_Advanced_Id { get; set; }

///<summary>
///優惠方案
///[char(36), nullable(True)]
///</summary>
public Guid? CouponSetting_Id { get; set; }

///<summary>
///折扣金額(新增時直接關聯couponsetting.payrate計算出折扣金額，或帶入折扣金額)
///[double, nullable(True)]
///</summary>
public Double? DiscountAmount { get; set; }
}
}
