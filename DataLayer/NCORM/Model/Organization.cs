using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///組織架構檔
/// </summary>
public class Organization : TableBase
{


///<summary>
///組織父Id
///</summary>
public Guid? Pid { get; set; }

///<summary>
///編號
///</summary>
public string Code { get; set; }

///<summary>
///全名
///</summary>
public string FullName { get; set; }

///<summary>
///簡短名
///</summary>
public string ShortName { get; set; }

///<summary>
///階層等級
///</summary>
public Byte? Rank { get; set; }

///<summary>
///排序
///</summary>
public string Ord { get; set; }
}
}
