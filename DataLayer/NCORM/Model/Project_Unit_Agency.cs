using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///計劃參與業者
/// </summary>
public class Project_Unit_Agency : TableBase
{



///<summary>
///上階ID
///[char(36), nullable(True)]
///</summary>
public Guid? Project_Unit_Assn_Id { get; set; }

///<summary>
///業者ID
///[char(36), nullable(True)]
///</summary>
public Guid? Agency_Id { get; set; }

///<summary>
///核定戶數(包)
///[int(11), nullable(True)]
///</summary>
public Int32 QtyA { get; set; }

///<summary>
///核定戶數(代)
///[int(11), nullable(True)]
///</summary>
public Int32 QtyB { get; set; }

///<summary>
///核定總經費
///[double, nullable(True)]
///</summary>
public Double Budget { get; set; }
}
}
