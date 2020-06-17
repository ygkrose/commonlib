using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.WEB
{
/// <summary>
///公司大樓簡介
/// </summary>
public class WEB_Company_Intro : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

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
///圖檔上傳
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }
}
}
