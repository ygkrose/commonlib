using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///捐贈碼
/// </summary>
public class DondateCode : TableBase
{



///<summary>
///捐贈碼
///[varchar(50), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///序號
///[varchar(4), nullable(True)]
///</summary>
public string Ord { get; set; }

///<summary>
///受捐贈單位名稱
///[varchar(50), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///受捐贈單位簡稱
///[varchar(20), nullable(True)]
///</summary>
public string ShortName { get; set; }

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
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
