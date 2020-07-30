using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///繳款單號帳款檔
/// </summary>
public class PaymentSlip_OffsetD : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid PaymentSlip_Id { get; set; }

///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///立帳單號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid OffsetD_Id { get; set; }

///<summary>
///金額
///[double, nullable(False)]
///</summary>
[Required]
public Double Amount { get; set; }
}
}
