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
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///上階
///</summary>
public Guid? PId { get; set; }

///<summary>
///描述
///</summary>
public string Name { get; set; }

///<summary>
///預設(0:否，1:是)
///</summary>
public UInt64 Default { get; set; }

///<summary>
///排序
///</summary>
public SByte Ord { get; set; }
}
}
