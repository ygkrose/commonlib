using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///科目傳輸設定
/// </summary>
public class TransCode : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///來源TABLE(TransCode, BankAccount, ChargeItem, Report)
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string SourceTable { get; set; }

///<summary>
///來源ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid SourceId { get; set; }

///<summary>
///會計科目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid AccountingItem_Id { get; set; }

///<summary>
///對應類別
///[varchar(20), nullable(True)]
///</summary>
public string Term { get; set; }
}
}
