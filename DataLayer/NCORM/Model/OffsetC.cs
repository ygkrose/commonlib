using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///貸方立帳單號表
/// </summary>
public class OffsetC : TableBase
{



///<summary>
///立帳單號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string OffsetNo { get; set; }

///<summary>
///會計科目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Accounting_Id { get; set; }

///<summary>
///金額
///[double, nullable(False)]
///</summary>
[Required]
public Double Amount { get; set; }

///<summary>
///來源類別(沖帳,折讓,作廢)
///[varchar(50), nullable(True)]
///</summary>
public string SourceTerm { get; set; }

///<summary>
///對應沖帳頭檔ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime AddDate { get; set; }

///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }
}
}
