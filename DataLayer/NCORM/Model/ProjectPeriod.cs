using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///計劃期數設定
/// </summary>
public class ProjectPeriod : TableBase
{


///<summary>
///計劃期數編號
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///計劃期數名稱
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///專案期數
///</summary>
[Required]
public Boolean PeriodId { get; set; }

///<summary>
///單位名稱
///</summary>
public string Sector { get; set; }

///<summary>
///計劃起日
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///計劃訖日
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///本期總經費
///</summary>
public Double Budget { get; set; }

///<summary>
///計劃總戶數
///</summary>
public Int32 ExpectedQty { get; set; }

///<summary>
///奉行政院核定日期
///</summary>
public DateTime? ApprovedDate { get; set; }

///<summary>
///計劃審核機制
///</summary>
public string Review { get; set; }
}
}
