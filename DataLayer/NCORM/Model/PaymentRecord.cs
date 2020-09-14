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
///繳款編號
///[varchar(20), nullable(True)]
///</summary>
public string PaymentNo { get; set; }

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
///銷帳說明
///[varchar(100), nullable(True)]
///</summary>
public string Memo { get; set; }

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

///<summary>
///合約編號
///[char(36), nullable(True)]
///</summary>
public Guid? Contract_Id { get; set; }

///<summary>
///總金額
///[double, nullable(True)]
///</summary>
public Double? TotalAmount { get; set; }
}
}
