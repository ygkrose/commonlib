using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///沖消帳資料
/// </summary>
public class PaymentRecord : TableBase
{



///<summary>
///繳費金額
///[double, nullable(True)]
///</summary>
public Double TransAmount { get; set; }

///<summary>
///繳款編號
///[varchar(20), nullable(True)]
///</summary>
public string PaymentNo { get; set; }

///<summary>
///實際交易手續費
///[double, nullable(True)]
///</summary>
public Double ActualFee { get; set; }

///<summary>
///交易手續費負擔方
///[varchar(20), nullable(True)]
///</summary>
public string FeePayer { get; set; }

///<summary>
///應入帳金額
///[double, nullable(True)]
///</summary>
public Double ExpectedAmount { get; set; }

///<summary>
///預計入帳日
///[date, nullable(True)]
///</summary>
public DateTime? ExpectedDate { get; set; }

///<summary>
///平台負擔手續費
///[double, nullable(True)]
///</summary>
public Double NcFee { get; set; }

///<summary>
///銷帳說明
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///實際入帳日
///[datetime, nullable(True)]
///</summary>
public DateTime? AccountDate { get; set; }

///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///核示人
///[char(36), nullable(True)]
///</summary>
public Guid? reviewUser_Id { get; set; }

///<summary>
///核示日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ReviewDate { get; set; }

///<summary>
///批號
///[varchar(10), nullable(True)]
///</summary>
public string BatchNo { get; set; }

///<summary>
///繳費日期
///[datetime, nullable(True)]
///</summary>
public DateTime? TransDate { get; set; }

///<summary>
///戶號
///[char(36), nullable(True)]
///</summary>
public Guid? House_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(True)]
///</summary>
public Guid? Client_Id { get; set; }

///<summary>
///繳款通路
///[varchar(10), nullable(True)]
///</summary>
public string Code_CollectType { get; set; }

///<summary>
///交易手續費
///[double, nullable(True)]
///</summary>
public Double SlipFee { get; set; }

///<summary>
///社區入帳金額
///[double, nullable(True)]
///</summary>
public Double AccountAmount { get; set; }

///<summary>
///單據日期
///[date, nullable(True)]
///</summary>
public DateTime? ReceiptDate { get; set; }

///<summary>
///單據號碼
///[varchar(20), nullable(True)]
///</summary>
public string ReceiptNo { get; set; }

///<summary>
///作廢人
///[char(36), nullable(True)]
///</summary>
public Guid? voidUser_Id { get; set; }

///<summary>
///作廢日期
///[datetime, nullable(True)]
///</summary>
public DateTime? VoidDate { get; set; }
}
}
