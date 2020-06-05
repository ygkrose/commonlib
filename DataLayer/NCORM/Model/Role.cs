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
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///名稱
///</summary>
public string Name { get; set; }

///<summary>
///說明
///</summary>
public string Description { get; set; }

///<summary>
///程式等級
///</summary>
[Required]
public Boolean ProgRank { get; set; }

///<summary>
///資料等級
///</summary>
[Required]
public Boolean DataRank { get; set; }

///<summary>
///欄位等級
///</summary>
[Required]
public Boolean FieldRank { get; set; }

///<summary>
///所屬組織頂層(top of same rank)
///</summary>
public Guid? RefOrganization_Id { get; set; }
}
}
