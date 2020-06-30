using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///使用者資料表
/// </summary>
public class UserData : TableBase
{



///<summary>
///使用者Id
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid User_Id { get; set; }

///<summary>
///帳號有效起日
///[datetime, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///帳號有效訖日
///[datetime, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///資料使用同意日
///[date, nullable(True)]
///</summary>
public DateTime? DataConsentDate { get; set; }

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

///<summary>
///討論區暱稱
///[varchar(50), nullable(True)]
///</summary>
public string Nickname { get; set; }
}
}
