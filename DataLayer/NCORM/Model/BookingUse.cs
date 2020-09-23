using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公設使用
/// </summary>
public class BookingUse : TableBase
{



///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

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
///使用日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///預約項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid BookingItem_Id { get; set; }

///<summary>
///使用人數
///[int(11), nullable(True)]
///</summary>
public Int32? PersonQty { get; set; }

///<summary>
///拍照上傳
///[char(36), nullable(True)]
///</summary>
public Guid? cameraFile_Id { get; set; }

///<summary>
///簽名檔
///[char(36), nullable(True)]
///</summary>
public Guid? signatureFile_Id { get; set; }

///<summary>
///桌號
///[char(36), nullable(True)]
///</summary>
public Guid? BookingTableNo_Id { get; set; }

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
///結帳人員
///[char(36), nullable(True)]
///</summary>
public Guid? settleUser_Id { get; set; }

///<summary>
///結帳日期
///[datetime, nullable(True)]
///</summary>
public DateTime? SettleDate { get; set; }

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
