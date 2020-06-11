using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///使用者隸屬的單位
/// </summary>
public class User_Org : TableBase
{



///<summary>
///使用者Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid USer_Id { get; set; }

///<summary>
///組織Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Org_Id { get; set; }

///<summary>
///是否預設(0:否 1:是)
///[bit(1), nullable(False)]
///</summary>
[Required]
public UInt64 IsDefault { get; set; }
}
}
