using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公會印鑑身檔/理事長
/// </summary>
public class Assn_Chairman : TableBase
{


///<summary>
///公會編號
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///理事長姓名
///</summary>
[Required]
public string Name { get; set; }

///<summary>
///任期起日
///</summary>
public DateTime? StartDate { get; set; }

///<summary>
///任期迄日
///</summary>
public DateTime? EndDate { get; set; }

///<summary>
///公司名稱
///</summary>
public string Company { get; set; }

///<summary>
///公司電話
///</summary>
public string Tel { get; set; }

///<summary>
///行動電話
///</summary>
public string Mobile { get; set; }

public string Memo { get; set; }
}
}
