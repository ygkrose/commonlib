using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目產品屬性明細
/// </summary>
public class BookingItem_Product_Property : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingItem_Product_Id { get; set; }

///<summary>
///屬性
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Property { get; set; }
}
}
