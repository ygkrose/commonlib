using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///使用者隸屬的單位
/// </summary>
public class User_Organization : TableBase
{


///<summary>
///使用者Id
///</summary>
[Required]
public Guid USer_Id { get; set; }

///<summary>
///組織Id
///</summary>
[Required]
public Guid Organization_Id { get; set; }

///<summary>
///是否預設(0:否 1:是)
///</summary>
[Required]
public UInt64 IsDefault { get; set; }
}
}
