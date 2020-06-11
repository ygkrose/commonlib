using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///公會印鑑身檔/理事長
/// </summary>
public class GRM_Assn_Chairman : TableBase
{



///<summary>
///公會編號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///理事長姓名
///[varchar(10), nullable(False)]
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///任期起日
///[date, nullable(True)]
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///任期迄日
///[date, nullable(True)]
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///公司名稱
///[varchar(30), nullable(True)]
///</summary>
public string Company { get; set; }

///<summary>
///公司電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///行動電話
///[varchar(10), nullable(True)]
///</summary>
public string Mobile { get; set; }

public string Memo { get; set; }
}
}
