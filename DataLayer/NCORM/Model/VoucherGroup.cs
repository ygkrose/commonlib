using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///彙總傳票
/// </summary>
public class VoucherGroup : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///傳票日期
///[date, nullable(True)]
///</summary>
public DateTime? Date { get; set; }

///<summary>
///傳票類別(現金、轉帳、調整)
///[varchar(30), nullable(True)]
///</summary>
public string VoucherTerm { get; set; }

///<summary>
///傳票編號
///[varchar(20), nullable(True)]
///</summary>
public string VoucherNo { get; set; }

///<summary>
///來源類別(銷貨單、收款、銷貨折讓、銷貨作廢、住戶退款，支出、付款、進貨退回、進貨作廢、廠商退款，應收票據異動、應付票據異動、期初應收開帳、期初預收開帳)
///[varchar(20), nullable(True)]
///</summary>
public string SourceTerm { get; set; }

///<summary>
///新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }
}
}
