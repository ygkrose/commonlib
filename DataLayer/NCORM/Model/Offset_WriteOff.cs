using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///沖帳單號資料
/// </summary>
public class Offset_WriteOff : TableBase
{



///<summary>
///稅金
///[double, nullable(False)]
///</summary>
[Required]
public Double TaxAmount { get; set; }

///<summary>
///未稅金額
///[double, nullable(True)]
///</summary>
public Double UntaxedAmount { get; set; }

///<summary>
///稅傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? tTransCode_Id { get; set; }

///<summary>
///貸方傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? cTransCode_Id { get; set; }

///<summary>
///借方傳輸ID
///[char(36), nullable(True)]
///</summary>
public Guid? dTransCode_Id { get; set; }
}
}
