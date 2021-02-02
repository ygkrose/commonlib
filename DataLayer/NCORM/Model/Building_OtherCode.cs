using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///部門自編大樓編號管理
/// </summary>
public class Building_OtherCode : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Building_Id { get; set; }

///<summary>
///部門
///[char(36), nullable(True)]
///</summary>
public Guid? Dept_Id { get; set; }

///<summary>
///部門自編編號
///[varchar(50), nullable(True)]
///</summary>
public string OtherCode { get; set; }

///<summary>
///備註
///[varchar(150), nullable(True)]
///</summary>
public string Memo { get; set; }

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
