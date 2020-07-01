using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///交易對象自然人資料
/// </summary>
public class ClientNatural : TableBase
{



///<summary>
///身分證字號
///[varchar(10), nullable(True)]
///</summary>
public string IdCardNo { get; set; }

///<summary>
///性別(F:女M:男)
///[char(1), nullable(True)]
///</summary>
public string Gender { get; set; }

///<summary>
///出生年月日
///[date, nullable(True)]
///</summary>
public DateTime? BDay { get; set; }

///<summary>
///戶口名簿戶號
///[varchar(8), nullable(True)]
///</summary>
public string HouseholdNo { get; set; }

///<summary>
///連絡電話
///[varchar(20), nullable(True)]
///</summary>
public string Tel { get; set; }

///<summary>
///手機
///[varchar(10), nullable(True)]
///</summary>
public string Mobile { get; set; }

///<summary>
///電子郵件
///[varchar(100), nullable(True)]
///</summary>
public string Email { get; set; }

///<summary>
///通訊縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? Region_Id { get; set; }

///<summary>
///通訊地址
///[varchar(200), nullable(True)]
///</summary>
public string Addr { get; set; }

///<summary>
///緊急聯絡人
///[varchar(10), nullable(True)]
///</summary>
public string EmerContact { get; set; }

///<summary>
///緊急聯絡人電話
///[varchar(10), nullable(True)]
///</summary>
public string EmerTel { get; set; }

///<summary>
///緊急聯絡人手機
///[varchar(10), nullable(True)]
///</summary>
public string EmerMobile { get; set; }

///<summary>
///職業
///[varchar(20), nullable(True)]
///</summary>
public string Job { get; set; }

///<summary>
///國籍
///[varchar(10), nullable(True)]
///</summary>
public string Nationality { get; set; }
}
}
