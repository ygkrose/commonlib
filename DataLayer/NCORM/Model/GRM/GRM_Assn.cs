using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model.GRM
{
/// <summary>
///縣市政府/公會資料
/// </summary>
public class GRM_Assn : TableBase
{



///<summary>
///縣市/公會編號
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///公會簡稱
///[varchar(50), nullable(False)]
///</summary>
[Required]
public string ShortName { get; set; }

///<summary>
///公會全銜
///[varchar(150), nullable(False)]
///</summary>
[Required]
public string FullName { get; set; }

///<summary>
///組織類別
///[varchar(50), nullable(True)]
///</summary>
public string AssnType { get; set; }

///<summary>
///代表人
///[varchar(50), nullable(True)]
///</summary>
public string Representative { get; set; }

///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GUINo { get; set; }

///<summary>
///登記縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///登記地址
///[varchar(100), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///聯絡人
///[varchar(50), nullable(True)]
///</summary>
public string Contact { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///EMAIL
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///管理者帳號
///[varchar(36), nullable(True)]
///</summary>
public string ManagerUserid { get; set; }

///<summary>
///備註
///[text, nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///對應的組織Id
///[char(36), nullable(True)]
///</summary>
public Guid? Org_Id { get; set; }
}
}
