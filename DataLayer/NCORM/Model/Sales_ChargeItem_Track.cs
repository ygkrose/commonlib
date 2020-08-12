using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///銷貨收費項目異動紀錄
/// </summary>
public class Sales_ChargeItem_Track : TableBase
{



///<summary>
///頭檔Id
///[char(36), nullable(True)]
///</summary>
public Guid? Sales_ChargeItem_Id { get; set; }

///<summary>
///來源類別(相同來源table可能有不同類別, 例如折扣vs.折讓)
///[varchar(20), nullable(True)]
///</summary>
public string SourceTerm { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }

///<summary>
///金額
///[char(36), nullable(True)]
///</summary>
public Guid? Amount { get; set; }

///<summary>
///異動時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///折扣金額
///[double, nullable(True)]
///</summary>
public Double? couponAmount { get; set; }

///<summary>
///優惠券ID
///[char(36), nullable(True)]
///</summary>
public Guid? Coupon_Id { get; set; }

///<summary>
///傳票別
///[varchar(20), nullable(True)]
///</summary>
public string VoucherTerm { get; set; }
}
}
