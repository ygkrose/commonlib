using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///使用者大樓權限
/// </summary>
public class User_Building : TableBase
{



///<summary>
///頭檔Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///起始日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///停用日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///預設(0:否1:是)
///[char(1), nullable(False)]
///</summary>
[Required]
public string IsDefault { get; set; }
}
}
