using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目開放日期明細
/// </summary>
public class BookingItem_OpenPeriod : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingItem_Id { get; set; }

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
///判斷改筆資料是(0:失效)或(1:啟用)
///[char(1), nullable(False)]
///</summary>
[Required]
public string IsActive { get; set; }

///<summary>
///記錄星期幾,用來描述IsActive的相反狀況
///[varchar(40), nullable(False)]
///</summary>
[Required]
public string ExcludeDay { get; set; }
}
}
