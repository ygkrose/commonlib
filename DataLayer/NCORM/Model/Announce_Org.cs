using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///指定公告組織
/// </summary>
public class Announce_Org : TableBase
{

///<summary>
///區域ID
///</summary>
[Required]
public Guid Region_Id { get; set; }

///<summary>
///組織ID
///</summary>
public Guid? Organization_Id { get; set; }

///<summary>
///公告ID
///</summary>
public Guid? Announce_Id { get; set; }
}
}
