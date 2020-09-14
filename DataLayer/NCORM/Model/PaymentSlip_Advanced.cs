using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///繳款單號預繳檔
/// </summary>
public class PaymentSlip_Advanced : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(True)]
///</summary>
public Guid? PaymentSlip_Id { get; set; }

///<summary>
///收費項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///每期金額
///[double, nullable(True)]
///</summary>
public Double? ChargeSettingListAmount { get; set; }

///<summary>
///應收總金額
///[double, nullable(True)]
///</summary>
public Double? OriginalAmount { get; set; }

///<summary>
///折扣總金額
///[double, nullable(True)]
///</summary>
public Double? DiscountAmount { get; set; }

///<summary>
///優惠應收金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///優惠生效月份
///[date, nullable(True)]
///</summary>
public DateTime? StartYearMonth { get; set; }

///<summary>
///總期數
///[date, nullable(True)]
///</summary>
public DateTime? TotalPeriod { get; set; }

///<summary>
///失效(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Disable { get; set; }
}
}
