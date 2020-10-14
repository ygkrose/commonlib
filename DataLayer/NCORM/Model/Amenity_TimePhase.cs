using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設項目時段明細
/// </summary>
public class Amenity_TimePhase : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Amenity_Id { get; set; }

///<summary>
///時段名稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///時間起
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime StartTime { get; set; }

///<summary>
///時間訖
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime EndTime { get; set; }

///<summary>
///可預約數量
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? LimitedQty { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///停用(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Disable { get; set; }
}
}
