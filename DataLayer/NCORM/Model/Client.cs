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
///自然人/法人
///[varchar(10), nullable(True)]
///</summary>
public string Person { get; set; }

///<summary>
///簡稱
///[varchar(20), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///全銜
///[varchar(80), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///所屬公司ID，用於篩選
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///電話1
///[varchar(20), nullable(True)]
///</summary>
public string Tel1 { get; set; }

///<summary>
///電話2
///[varchar(20), nullable(True)]
///</summary>
public string Tel2 { get; set; }

///<summary>
///手機
///[varchar(20), nullable(True)]
///</summary>
public string Mobile { get; set; }

///<summary>
///聯絡人
///[varchar(20), nullable(True)]
///</summary>
public string ContactPerson { get; set; }

///<summary>
///傳真
///[varchar(20), nullable(True)]
///</summary>
public string Fax { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
