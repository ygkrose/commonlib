using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///部門管理
/// </summary>
public class Dept : TableBase
{



///<summary>
///公司ID
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///部門代號
///[varchar(30), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///部門名稱
///[varchar(120), nullable(True)]
///</summary>
public string Name { get; set; }

///<summary>
///上階部門
///[char(36), nullable(True)]
///</summary>
public Guid? Pid { get; set; }

///<summary>
///營業屬性
///[varchar(30), nullable(True)]
///</summary>
public string Code_BusinessType { get; set; }

///<summary>
///損益屬性
///[varchar(30), nullable(True)]
///</summary>
public string Code_IncomeStatement { get; set; }

///<summary>
///縣市ID
///[char(36), nullable(True)]
///</summary>
public Guid? cityRegion_Id { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? townRegion_Id { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///聯絡電話
///[varchar(12), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///傳真
///[varchar(12), nullable(True)]
///</summary>
public string Fax { get; set; }

///<summary>
///撥款通知EMAIL
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///停用日期
///[datetime, nullable(True)]
///</summary>
public DateTime? StopDate { get; set; }

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
///新增日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
