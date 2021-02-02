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
///代碼
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
///層級
///[smallint(5) unsigned, nullable(True)]
///</summary>
public UInt16? Rank { get; set; }

///<summary>
///排序
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///地區天氣代碼
///[varchar(10), nullable(True)]
///</summary>
public string WeatherCode { get; set; }
}
}
