using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目產品明細
/// </summary>
public class BookingItem_Product : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingItem_Id { get; set; }

///<summary>
///小類
///[varchar(20), nullable(True)]
///</summary>
public string Code_ProductTerm { get; set; }

///<summary>
///品名
///[varchar(20), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///時間起
///[datetime, nullable(True)]
///</summary>
public DateTime? StartTime { get; set; }

///<summary>
///時間訖
///[datetime, nullable(True)]
///</summary>
public DateTime? EndTime { get; set; }

///<summary>
///當日可預約數量
///[int(11), nullable(True)]
///</summary>
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
