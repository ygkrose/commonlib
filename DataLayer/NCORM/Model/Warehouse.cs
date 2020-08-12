using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///倉庫管理
/// </summary>
public class Warehouse : TableBase
{



///<summary>
///組織
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Org_Id { get; set; }

///<summary>
///倉庫代號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///倉庫名稱
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///倉庫類別
///[varchar(50), nullable(True)]
///</summary>
public string WarehouseTerm { get; set; }

///<summary>
///倉庫地址
///[varchar(150), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///倉庫電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

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
}
}
