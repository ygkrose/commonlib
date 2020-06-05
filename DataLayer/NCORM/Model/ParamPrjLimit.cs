using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///參數設定
/// </summary>
public class ParamPrjLimit : TableBase
{


///<summary>
///計畫編號
///</summary>
[Required]
public Guid ProjectPeriod_Id { get; set; }

///<summary>
///參數代號
///</summary>
public string Code { get; set; }

///<summary>
///參數名稱
///</summary>
public string Name { get; set; }

///<summary>
///比例上限1
///</summary>
public Double MaxPercent1 { get; set; }

///<summary>
///比例上限2
///</summary>
public Double MaxPercent2 { get; set; }

///<summary>
///次數上限
///</summary>
public Boolean MaxTime { get; set; }

///<summary>
///年數上限
///</summary>
public Boolean MaxYear { get; set; }

///<summary>
///最小金額1
///</summary>
public Double MinAmount1 { get; set; }

///<summary>
///最大金額1
///</summary>
public Double MaxAmount1 { get; set; }

///<summary>
///最小金額2
///</summary>
public Double MinAmount2 { get; set; }

///<summary>
///最大金額2
///</summary>
public Double MaxAmount2 { get; set; }

public string Memo { get; set; }
}
}
