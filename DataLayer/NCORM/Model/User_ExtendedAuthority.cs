using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///帳號的擴展權限
/// </summary>
public class User_ExtendedAuthority : TableBase
{



///<summary>
///帳號Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///程式Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Program_AvaliableAction_Id { get; set; }

///<summary>
///資料新增人員
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
