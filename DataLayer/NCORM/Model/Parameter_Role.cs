using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///參數設定角色身檔
/// </summary>
public class Parameter_Role : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Parameter_Id { get; set; }

///<summary>
///角色ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Role_Id { get; set; }
}
}
