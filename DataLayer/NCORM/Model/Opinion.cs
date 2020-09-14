using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///管委會意見箱
/// </summary>
public class Opinion : TableBase
{



///<summary>
///大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///日期
///[datetime, nullable(True)]
///</summary>
public DateTime? Date { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///意見類別
///[varchar(30), nullable(True)]
///</summary>
public string OpinionTerm { get; set; }

///<summary>
///標題
///[varchar(150), nullable(True)]
///</summary>
public string Subject { get; set; }

///<summary>
///內容
///[varchar(350), nullable(True)]
///</summary>
public string Content { get; set; }

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
///上傳檔案
///[char(36), nullable(True)]
///</summary>
public Guid? File_UploadMap_Id { get; set; }
}
}
