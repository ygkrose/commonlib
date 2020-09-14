using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///銷貨退回商品明細
/// </summary>
public class Sales_ChargeItem_Track_Goods : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Sales_ChargeItem_Track_Id { get; set; }

///<summary>
///庫存異動紀錄ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Inventory_Id { get; set; }

///<summary>
///備註
///[varchar(50), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
