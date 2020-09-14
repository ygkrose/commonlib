using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///立帳單號貸方
/// </summary>
public class Voucher_EntryOffsetC : TableBase
{



///<summary>
///傳票分錄ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Voucher_Entry_Id { get; set; }

///<summary>
///立帳單號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string OffsetNo { get; set; }

///<summary>
///立帳類別
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string OffsetTerm { get; set; }
}
}
