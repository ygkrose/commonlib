using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///組織對應可用的程式
/// </summary>
public class Org_Program : TableBase
{



///<summary>
///組織Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Org_Id { get; set; }

///<summary>
///程式Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Program_AvaliableAction_Id { get; set; }
}
}
