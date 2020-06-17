using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///計劃期數設定
/// </summary>
public class GRM_Project : TableBase
{



///<summary>
///計劃期數編號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///計劃期數名稱
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///專案期數
///[smallint(6), nullable(False)]
///</summary>
[Required]
public Int16 PeriodId { get; set; }

///<summary>
///單位名稱
///[varchar(20), nullable(True)]
///</summary>
public string Sector { get; set; }

///<summary>
///計劃起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///計劃訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///本期總經費
///[double, nullable(True)]
///</summary>
public Double Budget { get; set; }

///<summary>
///計劃總戶數
///[int(11), nullable(True)]
///</summary>
public Int32 ExpectedQty { get; set; }

///<summary>
///奉行政院核定日期
///[date, nullable(True)]
///</summary>
public DateTime? ApprovedDate { get; set; }

///<summary>
///計劃審核機制
///[varchar(10), nullable(True)]
///</summary>
public string Review { get; set; }
}
}
