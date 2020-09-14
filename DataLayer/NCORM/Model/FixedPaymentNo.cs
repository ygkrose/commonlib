using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///固定繳款碼
/// </summary>
public class FixedPaymentNo : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Company_Id { get; set; }

///<summary>
///住戶
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid Client_Id { get; set; }

///<summary>
///類別(ATM、超商)
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PaymentNoTerm { get; set; }

///<summary>
///繳款碼
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string PaymentNo { get; set; }

///<summary>
///新增日期
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime AddDate { get; set; }

///<summary>
///註銷(0:否1:是)
///[char(1), nullable(False)]
///</summary>
[Required]
public string Disable { get; set; }
}
}
