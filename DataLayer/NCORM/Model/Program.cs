using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///程式基本資料檔
/// </summary>
public class Program : TableBase
{


///<summary>
///程式編號
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///</summary>
public string Name { get; set; }

///<summary>
///說明
///</summary>
public string Description { get; set; }

///<summary>
///URL
///</summary>
public string Url { get; set; }

///<summary>
///功能說明URL
///</summary>
public string UrlHelp { get; set; }
}
}
