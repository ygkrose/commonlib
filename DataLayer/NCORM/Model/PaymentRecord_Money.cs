using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收款銷帳金額身檔
/// </summary>
public class PaymentRecord_Money : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid PaymentRecord_Id { get; set; }

///<summary>
///金額類別(現金.銀存.管理費用.呆帳錯帳)
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string MoneyTerm { get; set; }

///<summary>
///來源傳票類別(1現金傳票3轉帳傳票)
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string VoucherTerm { get; set; }

///<summary>
///借方金額
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Amount { get; set; }

///<summary>
///往來帳戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BankAccount_Id { get; set; }

///<summary>
///說明
///[varchar(50), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
