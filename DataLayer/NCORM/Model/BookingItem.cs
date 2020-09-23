using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///預約項目管理
/// </summary>
public class BookingItem : TableBase
{



///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///三階代碼, 一般公設、點餐、代付墊, 各有小類
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_BookingItemTerm { get; set; }

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
///可使用點數類別
///[varchar(20), nullable(True)]
///</summary>
public string PointTerm { get; set; }

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
