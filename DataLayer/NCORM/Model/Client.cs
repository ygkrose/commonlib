using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///交易對象
/// </summary>
public class Client : TableBase
{



///<summary>
///對象編號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///對象類別
///[varchar(100), nullable(True)]
///</summary>
public string ClientType { get; set; }

///<summary>
///申請方案
///[varchar(100), nullable(True)]
///</summary>
public string Plan { get; set; }

///<summary>
///自然人/法人
///[varchar(10), nullable(True)]
///</summary>
public string Person { get; set; }

///<summary>
///簡稱
///[varchar(20), nullable(True)]
///</summary>
public string BriefName { get; set; }

///<summary>
///全銜
///[varchar(80), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///公司ID
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///討論區暱稱
///[varchar(50), nullable(True)]
///</summary>
public string Nickname { get; set; }
}
}
