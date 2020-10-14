using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目可用點數類別
/// </summary>
public class Amenity_TimePhase_PointTerm : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Amenity_TimePhase_Id { get; set; }

///<summary>
///點數類別,選單為Amenity_PointTerm的類別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PointTerm { get; set; }

///<summary>
///扣點點數
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? CostPoint { get; set; }
}
}
