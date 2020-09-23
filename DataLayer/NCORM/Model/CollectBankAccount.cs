using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代收帳戶管理
/// </summary>
public class CollectBankAccount : TableBase
{



///<summary>
///公司Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///往來帳戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BankAccount_Id { get; set; }

///<summary>
///啟用日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///終止日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///交易手續費負擔方(住戶client,管委會company,平台nc)
///[varchar(20), nullable(True)]
///</summary>
public string TransFeePayer { get; set; }

///<summary>
///撥款手續費負擔方
///[varchar(20), nullable(True)]
///</summary>
public string RemitFeePayer { get; set; }

///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }

///<summary>
///連絡人
///[varchar(20), nullable(True)]
///</summary>
public string Contact { get; set; }

///<summary>
///連絡電話
///[varchar(20), nullable(True)]
///</summary>
public string ContactTel { get; set; }

///<summary>
///撥款通知EMAIL
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///服務分類(凱基代收KGI或Bank)
///[varchar(20), nullable(True)]
///</summary>
public string Chain { get; set; }

///<summary>
///限定全繳(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string PayAll { get; set; }

///<summary>
///信用卡、超商、ATM、臨櫃
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string PayMethod { get; set; }
}
}
