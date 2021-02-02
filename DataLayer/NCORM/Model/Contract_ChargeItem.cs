using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收費設定
/// </summary>
public class Contract_ChargeItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Contract_Id { get; set; }

///<summary>
///客戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Customer_Id { get; set; }

///<summary>
///收費項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }

///<summary>
///車位
///[char(36), nullable(True)]
///</summary>
public Guid? ParkingSpace_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///課稅別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string TaxType { get; set; }

///<summary>
///稅率
///[double, nullable(False)]
///</summary>
[Required]
public Double? TaxRate { get; set; }

///<summary>
///起日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///訖日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///停用日期
///[datetime, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

///<summary>
///收費月份
///[int(11), nullable(True)]
///</summary>
public Int32? ChargeMonth { get; set; }

///<summary>
///收款週期
///[int(11), nullable(True)]
///</summary>
public Int32? Period { get; set; }

///<summary>
///每期含稅金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///請款規則(當月、提前1月、提前2月、延後1月、延後2月)
///[varchar(20), nullable(True)]
///</summary>
public string Code_SaleRule { get; set; }

///<summary>
///固定請款日
///[int(11), nullable(True)]
///</summary>
public Int32? FixedInvoiceDay { get; set; }

///<summary>
///發票稅籍
///[char(36), nullable(True)]
///</summary>
public Guid? InvoiceUnit_Id { get; set; }

///<summary>
///承租坪
///[int(11), nullable(True)]
///</summary>
public Int32? RentAreaPing { get; set; }

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
