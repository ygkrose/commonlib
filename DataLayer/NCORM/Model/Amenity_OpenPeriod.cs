using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設項目開放日設定有此表設定產生Amenity_OpenDate
/// </summary>
public class Amenity_OpenPeriod : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Amenity_Id { get; set; }

///<summary>
///起始日
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///終止日
///[datetime, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///排除國定假日(0:否)或(1:是)
///[char(1), nullable(False)]
///</summary>
[Required]
public string HolidayExcluded { get; set; }

///<summary>
///記錄星期幾,用來描述設定區間內的開放星期
///[varchar(40), nullable(False)]
///</summary>
[Required]
public string OpenWeekDay { get; set; }
}
}
