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
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///棟別
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Arch_Id { get; set; }

///<summary>
///有效起日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///有效訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///收費月份(老闆堅持留下，實際上用身檔值判斷)
///[smallint(1), nullable(False)]
///</summary>
[Required]
public Int16? ChargeMonth { get; set; }

///<summary>
///收款週期(老闆堅持留下，實際上用身檔值判斷)
///[smallint(1), nullable(False)]
///</summary>
[Required]
public Int16? Period { get; set; }

///<summary>
///銷貨項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///計算方法(戶,坪,平方公尺)
///[varchar(30), nullable(True)]
///</summary>
public string Code_ChargeBy { get; set; }

///<summary>
///單價
///[double, nullable(True)]
///</summary>
public Double? UnitPrice { get; set; }

///<summary>
///車位類型
///[varchar(20), nullable(True)]
///</summary>
public string Code_ParkingSpaceType { get; set; }
}
}
