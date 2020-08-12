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
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///角色Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Role_Id { get; set; }

///<summary>
///是否預設(0:否 1:是)
///[char(1), nullable(True)]
///</summary>
public string IsDefault { get; set; }
}
}
