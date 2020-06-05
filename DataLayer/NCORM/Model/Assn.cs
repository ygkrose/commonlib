using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///縣市政府/公會資料
/// </summary>
public class Assn : TableBase
{

///<summary>
///縣市/公會編號
///</summary>
[Required]
public string Code { get; set; }

///<summary>
///公會簡稱
///</summary>
[Required]
public string ShortName { get; set; }

///<summary>
///公會全銜
///</summary>
[Required]
public string FullName { get; set; }

///<summary>
///組織類別
///</summary>
public string AssnType { get; set; }

///<summary>
///代表人
///</summary>
public string Representative { get; set; }

///<summary>
///統一編號
///</summary>
public string GUINo { get; set; }

///<summary>
///登記縣市行政區
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///登記地址
///</summary>
public string Addr { get; set; }

///<summary>
///聯絡人
///</summary>
public string Contact { get; set; }

///<summary>
///電話
///</summary>
public string Tel { get; set; }

///<summary>
///EMAIL
///</summary>
public string Email { get; set; }

///<summary>
///管理者帳號
///</summary>
public string ManagerUserid { get; set; }

///<summary>
///備註
///</summary>
public string Memo { get; set; }

///<summary>
///對應的組織Id
///</summary>
public Guid? Organization_Id { get; set; }
}
}
