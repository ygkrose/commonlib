using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///計劃參與公會
/// </summary>
public class Project_Unit_Assn : TableBase
{


///<summary>
///上階ID
///</summary>
public Guid? Period_Unit_Id { get; set; }

///<summary>
///公會ID
///</summary>
public Guid? Assn_Id { get; set; }

///<summary>
///行政經費配額
///</summary>
public Double Budget1 { get; set; }

///<summary>
///公會管轄縣市經費配額
///</summary>
public Double Budget2 { get; set; }

///<summary>
///核定總經費
///</summary>
public Double TotalBudget { get; set; }

///<summary>
///經費啟用日
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///核定戶數(包)
///</summary>
public Int32 QtyA { get; set; }

///<summary>
///核定戶數(代)
///</summary>
public Int32 QtyB { get; set; }

///<summary>
///市場租金上限
///</summary>
public Double MaxRent { get; set; }

///<summary>
///租金評定計算方式
///</summary>
public string EvaluateType { get; set; }
}
}