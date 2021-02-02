using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///角色對應的資料權限
/// </summary>
public class Role_Org : TableBase
{



///<summary>
///角色Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Role_Id { get; set; }

///<summary>
///對應的組織Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Org_Id { get; set; }

///<summary>
///資料新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
