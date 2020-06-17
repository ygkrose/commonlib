using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///大樓委員屆別管理
/// </summary>
public class Company_Member : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///屆別
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///年度
///[char(3), nullable(False)]
///</summary>
[Required]
public string Year { get; set; }

///<summary>
///任期起日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime StartDate { get; set; }

///<summary>
///任期訖日
///[date, nullable(False)]
///</summary>
[Required]
public DateTime EndDate { get; set; }

///<summary>
///新增人員
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid AddUser_Id { get; set; }

///<summary>
///新增日期時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ModUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime ModDate { get; set; }
}
}
