using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收費設定
/// </summary>
public class ChargeSetting : TableBase
{



///<summary>
///收款設定名稱
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///有效起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///有效訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///收費月份
///[smallint(1), nullable(True)]
///</summary>
public Int16? ChargeMonth { get; set; }

///<summary>
///收款週期(單位月)
///[smallint(1), nullable(True)]
///</summary>
public Int16? Period { get; set; }

///<summary>
///銷貨項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///產生此筆收費設定的參數
///[text, nullable(True)]
///</summary>
public string Parameter { get; set; }
}
}
