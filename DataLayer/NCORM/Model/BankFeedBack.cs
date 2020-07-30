using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///銀行交易匯入檔
/// </summary>
public class BankFeedBack : TableBase
{



///<summary>
///資料來源
///[varchar(50), nullable(True)]
///</summary>
public string DataSource { get; set; }

///<summary>
///信託帳號
///[varchar(20), nullable(True)]
///</summary>
public string Account { get; set; }

///<summary>
///交易日
///[datetime, nullable(True)]
///</summary>
public DateTime? TransDate { get; set; }

///<summary>
///帳務日
///[date, nullable(True)]
///</summary>
public DateTime? CollectAccountDate { get; set; }

///<summary>
///預計入帳日
///[date, nullable(True)]
///</summary>
public DateTime? ExpectedDate { get; set; }

///<summary>
///通路類別
///[char(36), nullable(True)]
///</summary>
public Guid? Code_CollectType { get; set; }

///<summary>
///通路簡稱
///[varchar(30), nullable(True)]
///</summary>
public string CollectBrief { get; set; }

///<summary>
///繳款編號
///[varchar(50), nullable(True)]
///</summary>
public string PaymentNo { get; set; }

///<summary>
///正負
///[char(1), nullable(True)]
///</summary>
public string PlusMinus { get; set; }

///<summary>
///繳費金額
///[double, nullable(True)]
///</summary>
public Double Amount { get; set; }

///<summary>
///交易銀行代號
///[varchar(20), nullable(True)]
///</summary>
public string BankInfo_Code { get; set; }

///<summary>
///交易銀行簡稱
///[varchar(20), nullable(True)]
///</summary>
public string BankInfo_Shortname { get; set; }

///<summary>
///存繳人/附言
///[varchar(120), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///交易序號
///[varchar(50), nullable(True)]
///</summary>
public string TransSeq { get; set; }

///<summary>
///取消(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsCancel { get; set; }

///<summary>
///服務類別(凱基代收、介接的銀行代號)
///[varchar(10), nullable(True)]
///</summary>
public string Chain { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
