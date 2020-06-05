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
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///排序
///</summary>
[Required]
public SByte Sort { get; set; }

///<summary>
///簡介說明
///</summary>
public string Description { get; set; }

///<summary>
///圖片上傳的對應Id
///</summary>
public Guid? UploadFile_Id { get; set; }

///<summary>
///網站連結
///</summary>
public string Link { get; set; }

///<summary>
///360簡介
///</summary>
public string Img360 { get; set; }
}
}
