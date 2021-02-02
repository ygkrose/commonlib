using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代碼設定
/// </summary>
public class SysCode : TableBase
{


///<summary>
///代碼
///[varchar(30), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///上階
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///描述
///[varchar(100), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///預設(0:否，1:是)
///[char(1), nullable(True)]
///</summary>
public string IsDefault { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///公司Id
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }
}
}
