using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///戶號分割管理
/// </summary>
public class HouseSegment : TableBase
{



///<summary>
///戶號ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///起日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///訖日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///面積
///[date, nullable(False)]
///</summary>
[Required]
public DateTime BuildingAreaPing { get; set; }
}
}
