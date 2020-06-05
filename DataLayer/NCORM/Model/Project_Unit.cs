using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///計劃參與單位
/// </summary>
public class Project_Unit : TableBase
{


///<summary>
///計劃期數ID
///</summary>
[Required]
public Guid Project_Id { get; set; }

///<summary>
///單位ID
///</summary>
[Required]
public Guid Unit_Id { get; set; }

///<summary>
///公會開辦起日
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///公會開辦訖日
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///核定戶數(包)
///</summary>
public Int32 QtyA { get; set; }

///<summary>
///核定戶數(代)
///</summary>
public Int32 QtyB { get; set; }

///<summary>
///核定總經費
///</summary>
public Double Budget { get; set; }
}
}
