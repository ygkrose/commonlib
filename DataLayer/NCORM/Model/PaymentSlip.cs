using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///繳款單號檔
/// </summary>
public class PaymentSlip : TableBase
{



///<summary>
///Chain
///[varchar(20), nullable(True)]
///</summary>
public string Chain { get; set; }

///<summary>
///Api介面
///[varchar(20), nullable(True)]
///</summary>
public string ApiInterface { get; set; }

///<summary>
///產生時間
///[datetime, nullable(True)]
///</summary>
public DateTime? TransDate { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? User_Id { get; set; }

///<summary>
///手續費代號
///[varchar(20), nullable(True)]
///</summary>
public string RefCode { get; set; }

///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

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
///總金額
///[double, nullable(True)]
///</summary>
public Double Amount { get; set; }

///<summary>
///繳款編號
///[varchar(50), nullable(True)]
///</summary>
public string PaymentNo { get; set; }

///<summary>
///手續費
///[double, nullable(True)]
///</summary>
public Double Fee { get; set; }

///<summary>
///總金額含手續費
///[double, nullable(True)]
///</summary>
public Double FeeInAmount { get; set; }

///<summary>
///來源主機
///[varchar(50), nullable(True)]
///</summary>
public string SourceChain { get; set; }

///<summary>
///條碼1
///[varchar(50), nullable(True)]
///</summary>
public string BarCode1 { get; set; }

///<summary>
///條碼2
///[varchar(50), nullable(True)]
///</summary>
public string BarCode2 { get; set; }

///<summary>
///條碼3
///[varchar(50), nullable(True)]
///</summary>
public string BarCode3 { get; set; }

///<summary>
///預繳(0:否1:是)
///[bit(1), nullable(True)]
///</summary>
public UInt64 IsAdvanced { get; set; }
}
}
