using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///組織樹各Rank的對應資料
/// </summary>
public class OrgRankMap : TableBase
{

///<summary>
///階層
///</summary>
[Required]
public SByte Rank { get; set; }

///<summary>
///代碼
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///</summary>
[Required]
public string Name { get; set; }
}
}
