using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///計劃參與公會
/// </summary>
public class GRM_Project_Unit_Assn : TableBase
{



///<summary>
///上階ID
///[char(36), nullable(True)]
///</summary>
public Guid? Period_Unit_Id { get; set; }

///<summary>
///公會ID
///[char(36), nullable(True)]
///</summary>
public Guid? Assn_Id { get; set; }

///<summary>
///行政經費配額
///[double, nullable(True)]
///</summary>
public Double Budget1 { get; set; }

///<summary>
///公會管轄縣市經費配額
///[double, nullable(True)]
///</summary>
public Double Budget2 { get; set; }

///<summary>
///核定總經費
///[double, nullable(True)]
///</summary>
public Double TotalBudget { get; set; }

///<summary>
///經費啟用日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

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
///市場租金上限
///[double, nullable(True)]
///</summary>
public Double MaxRent { get; set; }

///<summary>
///租金評定計算方式
///[varchar(20), nullable(True)]
///</summary>
public string Code_Evaluate { get; set; }
}
}
