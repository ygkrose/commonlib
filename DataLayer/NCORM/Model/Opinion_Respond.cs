using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///管委會意見箱回覆明細
/// </summary>
public class Opinion_Respond : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Opinion_Id { get; set; }

///<summary>
///日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime Date { get; set; }

///<summary>
///回覆內容
///[varchar(500), nullable(True)]
///</summary>
public string Reply { get; set; }

///<summary>
///處理狀態
///[varchar(20), nullable(True)]
///</summary>
public string Code_RespondStatus { get; set; }

///<summary>
///圖檔上傳
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }

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
}
}
