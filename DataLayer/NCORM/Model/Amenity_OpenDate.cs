using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設開放日期一日一筆
/// </summary>
public class Amenity_OpenDate : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Amenity_Id { get; set; }

///<summary>
///日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///取消開放(0:否1:是)
///[char(1), nullable(False)]
///</summary>
[Required]
public string Disable { get; set; }

///<summary>
///取消說明
///[varchar(20), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
