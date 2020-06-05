using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///業者資料
/// </summary>
public class Agency : TableBase
{

///<summary>
///業者編號
///[varchar(15), nullable(True)]
///</summary>
public string Code { get; set; }

///<summary>
///業者簡稱
///[varchar(15), nullable(True)]
///</summary>
public string ShortName { get; set; }

///<summary>
///業者全銜
///[varchar(25), nullable(True)]
///</summary>
public string FullName { get; set; }

///<summary>
///統一編號
///[varchar(12), nullable(True)]
///</summary>
public string GUINo { get; set; }

///<summary>
///代表人
///[varchar(12), nullable(True)]
///</summary>
public string Representative { get; set; }

///<summary>
///登記縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? RegisteredRegion_Id { get; set; }

///<summary>
///登記地址
///[varchar(100), nullable(True)]
///</summary>
public string RegisteredAddr { get; set; }

///<summary>
///營業地址
///[varchar(100), nullable(True)]
///</summary>
public string BusinessAddr { get; set; }

///<summary>
///所屬公會
///[char(36), nullable(True)]
///</summary>
public Guid? Assn_Id { get; set; }

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
///傳真
///[varchar(20), nullable(True)]
///</summary>
public string Fax { get; set; }

///<summary>
///聯絡人
///[varchar(20), nullable(True)]
///</summary>
public string Contact { get; set; }

///<summary>
///電話
///[varchar(20), nullable(True)]
///</summary>
public string ContactTel { get; set; }

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
///對應的組織Id
///[char(36), nullable(True)]
///</summary>
public Guid? Organization_Id { get; set; }
}
}
