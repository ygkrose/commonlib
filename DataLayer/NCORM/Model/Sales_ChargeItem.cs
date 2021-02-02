using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///銷貨收費項目明細
/// </summary>
public class Sales_ChargeItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Sales_Id { get; set; }

///<summary>
///收費項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }

///<summary>
///金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///課稅別
///[varchar(20), nullable(True)]
///</summary>
public string TaxType { get; set; }

///<summary>
///稅率
///[double, nullable(True)]
///</summary>
public Double? TaxRate { get; set; }

///<summary>
///印單備註
///[varchar(100), nullable(True)]
///</summary>
public string SlipMemo { get; set; }

///<summary>
///費用起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///費用訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///費用年月
///[varchar(10), nullable(True)]
///</summary>
public string YearMonth { get; set; }

///<summary>
///車位
///[char(36), nullable(True)]
///</summary>
public Guid? ParkingSpace_Id { get; set; }

///<summary>
///來源類別
///[varchar(30), nullable(True)]
///</summary>
public string SourceTerm { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }

///<summary>
///發票稅籍
///[char(36), nullable(True)]
///</summary>
public Guid? InvoiceUnit_Id { get; set; }
}
}
