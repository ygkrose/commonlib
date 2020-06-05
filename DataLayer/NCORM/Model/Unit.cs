using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///計劃單位資料
/// </summary>
public class Unit : TableBase
{



///<summary>
///單位編號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///單位簡稱
///[varchar(50), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///單位全銜
///[varchar(100), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///對應的組織Id
///[char(36), nullable(True)]
///</summary>
public Guid? Organization_Id { get; set; }
}
}
