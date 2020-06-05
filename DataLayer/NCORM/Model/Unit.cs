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
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///單位簡稱
///</summary>
public string ShortName { get; set; }

///<summary>
///單位全銜
///</summary>
public string FullName { get; set; }

///<summary>
///對應的組織Id
///</summary>
public Guid? Organization_Id { get; set; }
}
}
