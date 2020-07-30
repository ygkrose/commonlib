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
///戶籍縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? householdRegion_Id { get; set; }

///<summary>
///戶籍地址
///[varchar(200), nullable(True)]
///</summary>
public string HouseholdAddr { get; set; }

///<summary>
///國籍
///[varchar(10), nullable(True)]
///</summary>
public string Nationality { get; set; }

///<summary>
///通訊縣市行政區
///[char(36), nullable(True)]
///</summary>
public Guid? mailingRegion_Id { get; set; }

///<summary>
///通訊地址
///[varchar(200), nullable(True)]
///</summary>
public string MailingAddr { get; set; }
}
}
