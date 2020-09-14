using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///商品
/// </summary>
public class Goods : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///商品編號
///[varchar(20), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///商品名稱
///[varchar(30), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///商品類別
///[varchar(20), nullable(True)]
///</summary>
public string Code_GoodsTerm { get; set; }

///<summary>
///銷貨單價
///[double, nullable(True)]
///</summary>
public Double? UnitPrice { get; set; }

///<summary>
///成本單價
///[double, nullable(True)]
///</summary>
public Double? Cost { get; set; }

///<summary>
///規格(個.支.張.台....)
///[varchar(10), nullable(True)]
///</summary>
public string Specification { get; set; }

///<summary>
///計算單位
///[varchar(20), nullable(True)]
///</summary>
public string Code_Unit { get; set; }

///<summary>
///預設採購廠商
///[char(36), nullable(True)]
///</summary>
public Guid? Supplier_Id { get; set; }

///<summary>
///存貨支出項目Id
///[char(36), nullable(True)]
///</summary>
public Guid? inventoryChargeItem_Id { get; set; }

///<summary>
///銷貨收費項目Id
///[char(36), nullable(True)]
///</summary>
public Guid? saleChargeItem_Id { get; set; }

///<summary>
///自用支出項目Id
///[char(36), nullable(True)]
///</summary>
public Guid? useChargeItem_Id { get; set; }

///<summary>
///說明
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///商品圖檔
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[date, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[date, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
