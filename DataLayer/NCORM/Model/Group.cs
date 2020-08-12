using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///集團管理
/// </summary>
public class Group : TableBase
{



///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GuiNo { get; set; }

///<summary>
///負責人
///[varchar(20), nullable(True)]
///</summary>
public string Chief { get; set; }

///<summary>
///區域ID
///[char(36), nullable(True)]
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///郵遞區號
///[char(5), nullable(True)]
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
///電子郵件
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

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
///版面風格
///[varchar(50), nullable(True)]
///</summary>
public string UiStyle { get; set; }

///<summary>
///授權數量
///[smallint(6), nullable(True)]
///</summary>
public Int16? AuthorizedQty { get; set; }
}
}
