using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓簡介
/// </summary>
public class Building_Intro : TableBase
{


///<summary>
///大樓Id編號
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///排序
///[varchar(4), nullable(False)]
///</summary>
[Required]
public string Ord { get; set; }

///<summary>
///簡介說明
///[text, nullable(True)]
///</summary>
public string Description { get; set; }

///<summary>
///圖片上傳的對應Id
///[char(36), nullable(True)]
///</summary>
public Guid? uploadFile_Id { get; set; }

///<summary>
///網站連結
///[varchar(70), nullable(True)]
///</summary>
public string Link { get; set; }

///<summary>
///360簡介檔上傳的對應Id
///[char(36), nullable(True)]
///</summary>
public Guid? img360File_Id { get; set; }
}
}
