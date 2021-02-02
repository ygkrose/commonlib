using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///繳款手續費設定
/// </summary>
public class BankAccount_FeeSetting : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BankAccount_Id { get; set; }

///<summary>
///上限金額
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? AmountLimit { get; set; }

///<summary>
///手續費
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Fee { get; set; }

///<summary>
///手續費代號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string RefCode { get; set; }
}
}
