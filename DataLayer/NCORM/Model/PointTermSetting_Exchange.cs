using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///點數購買方案
/// </summary>
public class PointTermSetting_Exchange : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid PointTermSetting_Id { get; set; }

///<summary>
///級距上限
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? LimitAmount { get; set; }

///<summary>
///現金點數換算比
///[double, nullable(False)]
///</summary>
[Required]
public Double? ExchangeRate { get; set; }

///<summary>
///滿額贈點%
///[double, nullable(False)]
///</summary>
[Required]
public Double? BonusRate { get; set; }

///<summary>
///滿額贈點點數
///[double, nullable(False)]
///</summary>
[Required]
public Double? BonusPoint { get; set; }

///<summary>
///停用(0:否1:是)
///[char(1), nullable(False)]
///</summary>
[Required]
public string Disable { get; set; }
}
}
