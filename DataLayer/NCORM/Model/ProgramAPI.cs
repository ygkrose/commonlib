using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///定義程式所使用的API
/// </summary>
public class ProgramAPI : TableBase
{


///<summary>
///程式Id
///</summary>
[Required]
public Guid Program_Id { get; set; }

///<summary>
///API名稱
///</summary>
[Required]
public string APIName { get; set; }
}
}
