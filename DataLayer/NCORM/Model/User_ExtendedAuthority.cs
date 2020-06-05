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
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///程式Id
///</summary>
[Required]
public Guid Program_Id { get; set; }
}
}
