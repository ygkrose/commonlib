using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///參數設定
/// </summary>
public class GRM_ParamPrjLimit : TableBase
{



///<summary>
///計畫編號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ProjectPeriod_Id { get; set; }

///<summary>
///參數代號
///[varchar(25), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///參數名稱
///[varchar(25), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///比例上限1
///[double, nullable(True)]
///</summary>
public Double MaxPercent1 { get; set; }

///<summary>
///比例上限2
///[double, nullable(True)]
///</summary>
public Double MaxPercent2 { get; set; }

///<summary>
///次數上限
///[smallint(6), nullable(True)]
///</summary>
public Int16 MaxTime { get; set; }

///<summary>
///年數上限
///[smallint(6), nullable(True)]
///</summary>
public Int16 MaxYear { get; set; }

///<summary>
///最小金額1
///[double, nullable(True)]
///</summary>
public Double MinAmount1 { get; set; }

///<summary>
///最大金額1
///[double, nullable(True)]
///</summary>
public Double MaxAmount1 { get; set; }

///<summary>
///最小金額2
///[double, nullable(True)]
///</summary>
public Double MinAmount2 { get; set; }

///<summary>
///最大金額2
///[double, nullable(True)]
///</summary>
public Double MaxAmount2 { get; set; }

public string Memo { get; set; }
}
}
