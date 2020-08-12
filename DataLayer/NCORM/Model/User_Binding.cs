using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///帳號綁定
/// </summary>
public class User_Binding : TableBase
{



///<summary>
///帳號Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///EMAIL\r\nAPPLE\r\nFB\r\nGOOGLE\r\nTWITTER
///[varchar(10), nullable(True)]
///</summary>
public string BindingCode { get; set; }

///<summary>
///資料
///[varchar(100), nullable(True)]
///</summary>
public string Data { get; set; }

///<summary>
///綁定的APP
///[varchar(60), nullable(True)]
///</summary>
public string BindingAppId { get; set; }

///<summary>
///預設
///[char(1), nullable(True)]
///</summary>
public string IsDefault { get; set; }
}
}
