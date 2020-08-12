using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///傳票身檔
/// </summary>
public class Voucher_Entry : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Voucher_Id { get; set; }

///<summary>
///序號
///[varchar(10), nullable(False)]
///</summary>
[Required]
public string Sort { get; set; }

///<summary>
///會計科目
///[char(36), nullable(True)]
///</summary>
public Guid? Accounting_Id { get; set; }

///<summary>
///費用項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///借方金額
///[int(11), nullable(True)]
///</summary>
public Int32? DAmount { get; set; }

///<summary>
///貸方金額
///[int(11), nullable(True)]
///</summary>
public Int32? CAmount { get; set; }

///<summary>
///摘要
///[varchar(100), nullable(True)]
///</summary>
public string Note { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
