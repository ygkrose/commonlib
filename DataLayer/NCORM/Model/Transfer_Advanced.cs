using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///移轉作業預保暫明細
/// </summary>
public class Transfer_Advanced : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Transfer_Id { get; set; }

///<summary>
///立帳ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Voucher_EntryOffsetC_Id { get; set; }

///<summary>
///目的收費項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid TargetChargeItem_Id { get; set; }

///<summary>
///金額
///[double, nullable(False)]
///</summary>
[Required]
public Double? Amount { get; set; }
}
}
