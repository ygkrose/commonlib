using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///彙總傳票分錄來源
/// </summary>
public class VoucherGroup_Entry_Source : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid VoucherGroup_Entry_Id { get; set; }

///<summary>
///來源ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Voucher_Entry_Id { get; set; }
}
}
