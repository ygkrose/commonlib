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
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///上階
///[char(36), nullable(True)]
///</summary>
public Guid? PId { get; set; }

///<summary>
///描述
///[varchar(100), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///預設(0:否，1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 Default { get; set; }

///<summary>
///排序
///[smallint(6), nullable(True)]
///</summary>
public Int16 Ord { get; set; }

///<summary>
///公司Id
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }
}
}
