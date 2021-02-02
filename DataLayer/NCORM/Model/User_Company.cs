using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///使用者公司權限
/// </summary>
public class User_Company : TableBase
{



///<summary>
///頭檔Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///公司
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///起始日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///停用日期
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///預設(0:否1:是)
///[char(1), nullable(True)]
///</summary>
public string IsDefault { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
