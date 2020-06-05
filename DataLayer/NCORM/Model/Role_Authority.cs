using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///角色權限
/// </summary>
public class Role_Authority : TableBase
{


///<summary>
///角色Id
///</summary>
[Required]
public Guid Role_Id { get; set; }

///<summary>
///程式ID
///</summary>
[Required]
public Guid Program_Id { get; set; }
}
}
