using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設項目
/// </summary>
public class Amenity : TableBase
{



///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Org_Id { get; set; }

///<summary>
///項目名稱
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///每戶每日可預約數上限
///[int(11), nullable(True)]
///</summary>
public Int32? HouseLimitedQty { get; set; }

///<summary>
///使用須知
///[varchar(100), nullable(True)]
///</summary>
public string Notice { get; set; }

///<summary>
///可提前預約日數
///[int(11), nullable(True)]
///</summary>
public Int32? PreDay { get; set; }

///<summary>
///可提前取消時數
///[int(11), nullable(True)]
///</summary>
public Int32? CancelHour { get; set; }

///<summary>
///停用(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string Disable { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
