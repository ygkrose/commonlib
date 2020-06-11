using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///角色
/// </summary>
public class Role : TableBase
{



///<summary>
///角色編號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///[varchar(30), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///說明
///[varchar(200), nullable(True)]
///</summary>
public string Description { get; set; }

///<summary>
///程式等級
///[tinyint(1), nullable(False)]
///</summary>
[Required]
public Boolean ProgRank { get; set; }

///<summary>
///資料等級
///[tinyint(1), nullable(False)]
///</summary>
[Required]
public Boolean DataRank { get; set; }

///<summary>
///欄位等級
///[tinyint(1), nullable(False)]
///</summary>
[Required]
public Boolean FieldRank { get; set; }

///<summary>
///所屬組織頂層(top of same rank)
///[char(36), nullable(True)]
///</summary>
public Guid? refOrg_Id { get; set; }
}
}
