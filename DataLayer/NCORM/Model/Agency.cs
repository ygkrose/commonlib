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
///</summary>
public string Code { get; set; }

///<summary>
///業者簡稱
///</summary>
public string ShortName { get; set; }

///<summary>
///業者全銜
///</summary>
public string FullName { get; set; }

///<summary>
///統一編號
///</summary>
public string GUINo { get; set; }

///<summary>
///代表人
///</summary>
public string Representative { get; set; }

///<summary>
///登記縣市行政區
///</summary>
public Guid? RegisteredRegion_Id { get; set; }

///<summary>
///登記地址
///</summary>
public string RegisteredAddr { get; set; }

///<summary>
///營業地址
///</summary>
public string BusinessAddr { get; set; }

///<summary>
///所屬公會
///</summary>
public Guid? Assn_Id { get; set; }

///<summary>
///電話1
///</summary>
public string Tel1 { get; set; }

///<summary>
///電話2
///</summary>
public string Tel2 { get; set; }

///<summary>
///傳真
///</summary>
public string Fax { get; set; }

///<summary>
///聯絡人
///</summary>
public string Contact { get; set; }

///<summary>
///電話
///</summary>
public string ContactTel { get; set; }

///<summary>
///EMAIL
///</summary>
public string Email { get; set; }

///<summary>
///管理者帳號
///</summary>
public string ManagerUserid { get; set; }

///<summary>
///對應的組織Id
///</summary>
public Guid? Organization_Id { get; set; }
}
}
