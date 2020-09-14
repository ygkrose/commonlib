using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///定義程式所使用的API
/// </summary>
public class Program_AvaliableAction : TableBase
{



///<summary>
///程式Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Program_Id { get; set; }

///<summary>
///動作編號(Insert/Update/Delete/Select/Print...)
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string ActionCode { get; set; }

///<summary>
///方法名稱
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string ActionName { get; set; }
}
}
