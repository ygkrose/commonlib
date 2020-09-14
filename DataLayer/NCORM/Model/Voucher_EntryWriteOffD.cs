using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///沖帳單號借方
/// </summary>
public class Voucher_EntryWriteOffD : TableBase
{



///<summary>
///傳票分錄ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Voucher_Entry_Id { get; set; }

///<summary>
///沖帳單號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string WriteOffNo { get; set; }

///<summary>
///沖帳類別
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string WriteOffTerm { get; set; }
}
}
