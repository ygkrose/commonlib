using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///借方沖帳單號表
/// </summary>
public class Offset_WriteOffD : TableBase
{



///<summary>
///立帳單號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid OffsetD_Id { get; set; }

///<summary>
///沖帳單號
///[varchar(20), nullable(True)]
///</summary>
public string WriteOffNo { get; set; }

///<summary>
///類別
///[varchar(20), nullable(True)]
///</summary>
public string WriteOffTerm { get; set; }

///<summary>
///會計科目
///[char(36), nullable(True)]
///</summary>
public Guid? Accounting_Id { get; set; }

///<summary>
///金額
///[double, nullable(False)]
///</summary>
[Required]
public Double Amount { get; set; }

///<summary>
///來源類別
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string SourceTerm { get; set; }

///<summary>
///來源ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid SourceId { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime AddDate { get; set; }
}
}
