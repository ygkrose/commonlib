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
///</summary>
[Required]
public Guid Organization_Id { get; set; }

///<summary>
///程式Id
///</summary>
[Required]
public Guid Program_Id { get; set; }
}
}
