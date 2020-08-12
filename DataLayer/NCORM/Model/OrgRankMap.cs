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
///[smallint(6), nullable(False)]
///</summary>
[Required]
public Int16? Rank { get; set; }

///<summary>
///代碼
///[varchar(10), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }
}
}
