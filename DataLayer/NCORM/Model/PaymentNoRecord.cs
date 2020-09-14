using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///代收Gateway上繳款碼申請紀錄表
/// </summary>
public class PaymentNoRecord : TableBase
{



///<summary>
///來源主機
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ServerSetting_Id { get; set; }

///<summary>
///寫入時間
///[datetime, nullable(False)]
///</summary>
[Required]
public DateTime AddDate { get; set; }

///<summary>
///繳款碼
///[varchar(20), nullable(True)]
///</summary>
public string PaymentNo { get; set; }

///<summary>
///繳費金額
///[double, nullable(True)]
///</summary>
public Double? TransAmount { get; set; }

///<summary>
///繳費日期
///[datetime, nullable(True)]
///</summary>
public DateTime? TransDate { get; set; }
}
}
