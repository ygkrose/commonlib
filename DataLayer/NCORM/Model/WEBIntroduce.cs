using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公司大樓簡介
/// </summary>
public class WEBIntroduce : TableBase
{



///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///標題
///[varchar(50), nullable(True)]
///</summary>
public string Title { get; set; }

///<summary>
///內容
///[tinytext, nullable(True)]
///</summary>
public string Content { get; set; }

///<summary>
///平面圖
///[char(36), nullable(True)]
///</summary>
public Guid? planFile_UploadMap_Id { get; set; }

///<summary>
///全景照圖檔
///[char(36), nullable(True)]
///</summary>
public Guid? panoramaFile_Id { get; set; }

///<summary>
///置頂(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string OnTop { get; set; }

///<summary>
///簡介類型
///[varchar(20), nullable(True)]
///</summary>
public string Code_IntroType { get; set; }

///<summary>
///起始日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///結束日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///連結網址
///[varchar(250), nullable(True)]
///</summary>
public string Url { get; set; }

///<summary>
///BIM連結網址
///[varchar(250), nullable(True)]
///</summary>
public string BimUrl { get; set; }

///<summary>
///不顯示(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsHidden { get; set; }

///<summary>
///審核人員
///[char(36), nullable(True)]
///</summary>
public Guid? reviewUser_Id { get; set; }

///<summary>
///審核日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ReviewDate { get; set; }

///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///戶號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid House_Id { get; set; }
}
}
