using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///組織架構檔
/// </summary>
public class Org : TableBase
{



///<summary>
///組織父Id
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///編號
///[varchar(10), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///全名
///[varchar(50), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///簡短名
///[varchar(8), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///階層等級
///[smallint(5) unsigned, nullable(True)]
///</summary>
public UInt16 Rank { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }
}
}
