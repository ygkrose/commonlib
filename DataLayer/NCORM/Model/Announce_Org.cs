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
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Region_Id { get; set; }

///<summary>
///組織ID
///[char(36), nullable(True)]
///</summary>
public Guid? Org_Id { get; set; }

///<summary>
///公告ID
///[char(36), nullable(True)]
///</summary>
public Guid? Announce_Id { get; set; }

///<summary>
///組織層級
///[tinyint(4), nullable(True)]
///</summary>
public SByte Org_Rank { get; set; }
}
}
