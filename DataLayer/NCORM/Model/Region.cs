using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///行政區
/// </summary>
public class Region : TableBase
{



///<summary>
///區域父ID
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///階層
///[varchar(12), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///全名
///[varchar(50), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///簡短名
///[varchar(10), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///排序
///[tinyint(3) unsigned, nullable(True)]
///</summary>
public Byte? Rank { get; set; }

public string Ord { get; set; }
}
}
