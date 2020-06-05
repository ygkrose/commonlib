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
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///[varchar(30), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///說明
///[varchar(200), nullable(True)]
///</summary>
public string Description { get; set; }

///<summary>
///URL
///[varchar(200), nullable(True)]
///</summary>
public string Url { get; set; }

///<summary>
///功能說明URL
///[varchar(200), nullable(True)]
///</summary>
public string UrlHelp { get; set; }
}
}
