using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///公司
/// </summary>
public class Company : TableBase
{



///<summary>
///代號
///[varchar(30), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///簡稱
///[varchar(30), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///全銜
///[varchar(100), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///所屬集團
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Group_Id { get; set; }

///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }

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
///郵遞區號
///[varchar(10), nullable(True)]
///</summary>
public string ZipCode { get; set; }

///<summary>
///地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///傳真
///[varchar(20), nullable(True)]
///</summary>
public string Fax { get; set; }

///<summary>
///聯絡人職稱
///[varchar(15), nullable(True)]
///</summary>
public string ContactJobTitle { get; set; }

///<summary>
///聯絡人
///[varchar(20), nullable(True)]
///</summary>
public string Contact { get; set; }

///<summary>
///聯絡電話
///[varchar(20), nullable(True)]
///</summary>
public string ContactTel { get; set; }

///<summary>
///EMAIL
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///網址
///[varchar(150), nullable(True)]
///</summary>
public string Website { get; set; }

///<summary>
///備註
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }
}
}
