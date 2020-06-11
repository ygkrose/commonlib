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
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Program_Id { get; set; }

///<summary>
///API名稱
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string APIName { get; set; }
}
}
