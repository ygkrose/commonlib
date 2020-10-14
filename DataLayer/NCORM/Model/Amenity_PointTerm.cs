using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設項目可用點數類別
/// </summary>
public class Amenity_PointTerm : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Amenity_Id { get; set; }

///<summary>
///點數類別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PointTerm { get; set; }

///<summary>
///優先序
///[varchar(4), nullable(False)]
///</summary>
[Required]
public string Ord { get; set; }
}
}
