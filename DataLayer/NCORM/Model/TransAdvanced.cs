using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預收款轉換
/// </summary>
public class TransAdvanced : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///轉換日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime TransDate { get; set; }

///<summary>
///轉換類別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string AdvanceTerm { get; set; }

///<summary>
///來源戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid FromHouse_Id { get; set; }

///<summary>
///來源住戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid FromClient_Id { get; set; }

///<summary>
///目的戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ToHouse_Id { get; set; }

///<summary>
///目的住戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ToClient_Id { get; set; }

///<summary>
///金額
///[double, nullable(False)]
///</summary>
[Required]
public Double? Amount { get; set; }

///<summary>
///來源指定項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid FromChargeItem_Id { get; set; }

///<summary>
///目的指定項目
///[char(36), nullable(True)]
///</summary>
public Guid? toChargeItem_Id { get; set; }

///<summary>
///備註
///[varchar(50), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }
}
}
