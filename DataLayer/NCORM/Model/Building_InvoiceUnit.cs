using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收費項目對應發票稅籍
/// </summary>
public class Building_InvoiceUnit : TableBase
{



///<summary>
///收費項目ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///發票稅籍
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid InvoiceUnit_Id { get; set; }

///<summary>
///收費月份(預設值供ChargeSetting新增時取用)
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? ChargeMonth { get; set; }

///<summary>
///收款週期(預設值供ChargeSetting新增時取用)
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Period { get; set; }
}
}
