using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///彙總傳票分錄
/// </summary>
public class VoucherGroup_Entry : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid VoucherGroup_Id { get; set; }

///<summary>
///序號
///[char(4), nullable(True)]
///</summary>
public string Sort { get; set; }

///<summary>
///會計科目
///[char(36), nullable(True)]
///</summary>
public Guid? AccountingItem_Id { get; set; }

///<summary>
///借方金額
///[double, nullable(True)]
///</summary>
public Double? DAmount { get; set; }

///<summary>
///貸方金額
///[double, nullable(True)]
///</summary>
public Double? CAmount { get; set; }

///<summary>
///摘要
///[varchar(200), nullable(True)]
///</summary>
public string Note { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
