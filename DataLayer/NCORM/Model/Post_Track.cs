using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///郵件處理紀錄
/// </summary>
public class Post_Track : TableBase
{



///<summary>
///郵件Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Post_Id { get; set; }

///<summary>
///狀態類別(領信、待退信(退回管理中心)、退信(退回郵差)、變更戶號、作廢..)
///[varchar(20), nullable(True)]
///</summary>
public string Code_PostStatus { get; set; }

///<summary>
///拍照圖檔
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }

///<summary>
///簽名檔
///[char(36), nullable(True)]
///</summary>
public Guid? signFile_Id { get; set; }

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
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
