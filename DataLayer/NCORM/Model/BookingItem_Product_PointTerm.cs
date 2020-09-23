using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目可用點數類別
/// </summary>
public class BookingItem_Product_PointTerm : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingItem_Product_Id { get; set; }

///<summary>
///點數類別
///[varchar(20), nullable(True)]
///</summary>
public string PointTerm { get; set; }

///<summary>
///扣點點數
///[int(11), nullable(True)]
///</summary>
public Int32? CostPoint { get; set; }

///<summary>
///優先序(若同時可使用多種點數, 結帳時自動依優先序扣點)
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }
}
}
