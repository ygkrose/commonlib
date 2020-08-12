using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///計劃參與單位
/// </summary>
public class GRM_Project_Unit : TableBase
{



///<summary>
///計劃期數ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Project_Id { get; set; }

///<summary>
///單位ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Unit_Id { get; set; }

///<summary>
///公會開辦起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///公會開辦訖日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///核定戶數(包)
///[int(11), nullable(True)]
///</summary>
public Int32? QtyA { get; set; }

///<summary>
///核定戶數(代)
///[int(11), nullable(True)]
///</summary>
public Int32? QtyB { get; set; }

///<summary>
///核定總經費
///[double, nullable(True)]
///</summary>
public Double? Budget { get; set; }
}
}
