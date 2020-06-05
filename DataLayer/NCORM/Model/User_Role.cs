using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///定義user對應到的角色
/// </summary>
public class User_Role : TableBase
{


///<summary>
///使用者ID
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///角色Id
///</summary>
[Required]
public Guid Role_Id { get; set; }

///<summary>
///是否預設(0:否 1:是)
///</summary>
public UInt64 IsDefault { get; set; }
}
}
