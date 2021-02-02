using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///報修登錄商品明細
/// </summary>
public class CrmRecord_Goods : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid CrmRecord_Id { get; set; }

///<summary>
///商品
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Goods_Id { get; set; }

///<summary>
///單價
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid UnitPrice { get; set; }

///<summary>
///數量
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Qty { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
