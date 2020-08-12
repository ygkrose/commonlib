using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///借方立帳單
/// </summary>
public class OffsetD : TableBase
{



///<summary>
///立帳單號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string OffsetNo { get; set; }

///<summary>
///收費項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }

///<summary>
///課稅別
///[varchar(10), nullable(False)]
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
///會計科目
///[char(36), nullable(True)]
///</summary>
public Guid? AccountingItem_Id { get; set; }

///<summary>
///金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///立帳類別(立應付.立預付.立存入保證金.立存出保證金.立應付票)
///[varchar(20), nullable(True)]
///</summary>
public string OffsetTerm { get; set; }

///<summary>
///來源TABLE
///[varchar(20), nullable(True)]
///</summary>
public string SourceTable { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }

///<summary>
///借方傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? dTransCode_Id { get; set; }

///<summary>
///貸方傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? cTransCode_Id { get; set; }

///<summary>
///稅傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? tTransCode_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
