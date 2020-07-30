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
///[smallint(6), nullable(True)]
///</summary>
public Int16 Org_Rank { get; set; }
}
}
