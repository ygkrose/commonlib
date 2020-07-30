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
public Guid ArWriteOff_Id { get; set; }

///<summary>
///金額來源/使用類別(A.現金.銀存.B.票據.取預收.取保證金.取暫收.管理費用.呆帳錯帳C.(沖帳金額).收預收款.收保證金.收暫收款)
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
public Int32 DAmount { get; set; }

///<summary>
///貸方金額
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32 CAmount { get; set; }

///<summary>
///往來帳戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BankAccount_Id { get; set; }

public string Memo { get; set; }
}
}
