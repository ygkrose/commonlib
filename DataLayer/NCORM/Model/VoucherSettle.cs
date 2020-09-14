using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///傳票結帳檔
/// </summary>
public class VoucherSettle : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///結帳類別(日結.月結.年結)
///[varchar(20), nullable(True)]
///</summary>
public string SettleTerm { get; set; }

///<summary>
///結帳日期
///[date, nullable(True)]
///</summary>
public DateTime? SettleDate { get; set; }

///<summary>
///會計科目
///[char(36), nullable(True)]
///</summary>
public Guid? AccountingItem_Id { get; set; }

///<summary>
///結餘金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
