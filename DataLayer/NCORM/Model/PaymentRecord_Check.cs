using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收款銷帳票據明細
/// </summary>
public class PaymentRecord_Check : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ArWriteOff_Id { get; set; }

///<summary>
///支票號碼
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string ArCheck { get; set; }

///<summary>
///到期日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime PayDate { get; set; }

///<summary>
///金額
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32 Amount { get; set; }

///<summary>
///入帳帳號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BankAccount_Id { get; set; }

///<summary>
///入帳銀行
///[varchar(120), nullable(True)]
///</summary>
public string BankShortName { get; set; }

///<summary>
///支票帳號
///[varchar(50), nullable(True)]
///</summary>
public string CheckAccount { get; set; }

///<summary>
///是否客票(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 TransCheck { get; set; }

///<summary>
///禁止背書轉讓(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 NonTransferable { get; set; }

///<summary>
///發票人
///[varchar(120), nullable(True)]
///</summary>
public string Drawer { get; set; }
}
}
