using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收費設定身檔
/// </summary>
public class ChargeSetting_List : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeSetting_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///車位
///[char(36), nullable(True)]
///</summary>
public Guid? ParkingSpace_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Customer_Id { get; set; }

///<summary>
///金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///備註
///[varchar(50), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[date, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[date, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }

///<summary>
///收費起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///收費訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///收費月份
///[smallint(1), nullable(False)]
///</summary>
[Required]
public Int16? ChargeMonth { get; set; }

///<summary>
///收款週期(單位月)
///[smallint(1), nullable(False)]
///</summary>
[Required]
public Int16? Period { get; set; }
}
}
