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
///</summary>
public Guid? Project_Unit_Assn_Id { get; set; }

///<summary>
///業者ID
///</summary>
public Guid? Agency_Id { get; set; }

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
