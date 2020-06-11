using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///帳戶科目管理
/// </summary>
public class BankAccount_Accounting : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BankAccount_Id { get; set; }

///<summary>
///科目類別(銀行存款、應收票據、應付票據、匯費)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string AccountingType { get; set; }

///<summary>
///會計科目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Accounting_Id { get; set; }
}
}
