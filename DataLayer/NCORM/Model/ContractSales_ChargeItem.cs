using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///產生合約收費應收明細
/// </summary>
public class ContractSales_ChargeItem : TableBase
{



///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ContractSales_Id { get; set; }

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
///合約收費設定
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Contract_ChargeItem_Id { get; set; }

///<summary>
///費用起日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///費用訖日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///含稅總金額
///[double, nullable(False)]
///</summary>
[Required]
public Double? Amount { get; set; }

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
///彙總0/1
///[char(1), nullable(True)]
///</summary>
public string Sum { get; set; }

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
}
}
