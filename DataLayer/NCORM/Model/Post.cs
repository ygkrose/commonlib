using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///郵件管理
/// </summary>
public class Post : TableBase
{



///<summary>
///收信時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime ReceiveDate { get; set; }

///<summary>
///當日掛號序號
///[char(10), nullable(True)]
///</summary>
public string DaySeq { get; set; }

///<summary>
///公司大樓Id
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///棟別Id
///[char(36), nullable(True)]
///</summary>
public Guid? Building_Id { get; set; }

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
///收件人
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///郵件類別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code_PostTerm { get; set; }

///<summary>
///寄件單位
///[varchar(50), nullable(True)]
///</summary>
public string Sender { get; set; }

///<summary>
///郵件條碼
///[varchar(50), nullable(True)]
///</summary>
public string Barcode { get; set; }

///<summary>
///郵件圖檔
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }

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
