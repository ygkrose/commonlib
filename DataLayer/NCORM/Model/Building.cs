using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///棟別
/// </summary>
public class Building : TableBase
{



///<summary>
///對應組織ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Org_Id { get; set; }

///<summary>
///門牌
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///房屋類型
///[varchar(20), nullable(True)]
///</summary>
public string Code_House { get; set; }
}
}
