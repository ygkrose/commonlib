using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///庫存異動檔
/// </summary>
public class Inventory : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///倉庫id
///[char(36), nullable(True)]
///</summary>
public Guid? Warehouse_Id { get; set; }

///<summary>
///來源類別(銷貨、採購.......)
///[varchar(30), nullable(True)]
///</summary>
public string SourceTerm { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }

///<summary>
///入出庫(In / Out)
///[char(3), nullable(True)]
///</summary>
public string InOut { get; set; }

///<summary>
///商品Id
///[char(36), nullable(True)]
///</summary>
public Guid? Goods_Id { get; set; }

///<summary>
///單價
///[double, nullable(True)]
///</summary>
public Double? UnitPrice { get; set; }

///<summary>
///小計
///[double, nullable(True)]
///</summary>
public Double? TotalPrice { get; set; }

///<summary>
///數量
///[int(11), nullable(True)]
///</summary>
public Int32? Qty { get; set; }

///<summary>
///品質
///[varchar(20), nullable(True)]
///</summary>
public string Code_InventoryQuality { get; set; }

///<summary>
///新增時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
