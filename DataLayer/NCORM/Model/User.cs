using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///使用者帳號基本資料
/// </summary>
public class User : TableBase
{



///<summary>
///帳號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///姓名
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///密碼(MD5)
///[char(32), nullable(False)]
///</summary>
[Required]
public string Password { get; set; }

///<summary>
///大頭照
///[char(36), nullable(True)]
///</summary>
public Guid? headshotFile_Id { get; set; }
}
}
