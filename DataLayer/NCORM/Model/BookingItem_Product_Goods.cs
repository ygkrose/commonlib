using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目產品對應商品明細
/// </summary>
public class BookingItem_Product_Goods : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingItem_Product_Id { get; set; }

///<summary>
///商品
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Goods_Id { get; set; }

///<summary>
///數量
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Qty { get; set; }
}
}
