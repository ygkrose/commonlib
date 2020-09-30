using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設預約
/// </summary>
public class BookingRecord : TableBase
{



///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Org_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Client_Id { get; set; }

///<summary>
///連絡電話
///[varchar(15), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///Email
///[varchar(120), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///預約項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Amenity_Id { get; set; }

///<summary>
///預約日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///時段
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Amenity_TimePhase_Id { get; set; }

///<summary>
///預約數量
///[int(11), nullable(True)]
///</summary>
public Int32? BookingQty { get; set; }

///<summary>
///預計使用人數
///[int(11), nullable(True)]
///</summary>
public Int32? PersonQty { get; set; }

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
///取消人員
///[char(36), nullable(True)]
///</summary>
public Guid? cancelUser_Id { get; set; }

///<summary>
///取消日期
///[datetime, nullable(True)]
///</summary>
public DateTime? CancelDate { get; set; }
}
}
