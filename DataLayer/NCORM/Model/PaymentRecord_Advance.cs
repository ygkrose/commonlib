using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收款銷帳預收明細
/// </summary>
public class PaymentRecord_Advance : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid PaymentRecord_Id { get; set; }

///<summary>
///收/取
///[varchar(3), nullable(True)]
///</summary>
public string InOut { get; set; }

///<summary>
///收費項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///原每期金額
///[int(11), nullable(True)]
///</summary>
public Int32? OriginalArAmount { get; set; }

///<summary>
///優惠方案
///[char(36), nullable(True)]
///</summary>
public Guid? CouponSetting_Id { get; set; }

///<summary>
///預收金額
///[int(11), nullable(True)]
///</summary>
public Int32? Amount { get; set; }

///<summary>
///預收期間
///[varchar(50), nullable(True)]
///</summary>
public string AdvanceMemo { get; set; }
}
}
