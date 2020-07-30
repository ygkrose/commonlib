using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///傳票頭檔
/// </summary>
public class Voucher : TableBase
{



///<summary>
///公司大樓
///[char(36), nullable(True)]
///</summary>
public Guid? Company_Id { get; set; }

///<summary>
///傳票日期
///[date, nullable(False)]
///</summary>
[Required]
public DateTime VoucherDate { get; set; }

///<summary>
///傳票類別(現金、轉帳、調整)
///[varchar(20), nullable(True)]
///</summary>
public string VoucherTerm { get; set; }

///<summary>
///傳票編號
///[varchar(20), nullable(False)]
///</summary>
[Required]
public string VoucherNo { get; set; }

///<summary>
///總金額
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32 Amount { get; set; }

///<summary>
///備註
///[varchar(200), nullable(True)]
///</summary>
public string Memo { get; set; }

///<summary>
///來源類別
///[varchar(50), nullable(True)]
///</summary>
public string SourceTerm { get; set; }

///<summary>
///來源ID
///[char(36), nullable(True)]
///</summary>
public Guid? SourceId { get; set; }

///<summary>
///核示人員
///[char(36), nullable(True)]
///</summary>
public Guid? reviewUser_Id { get; set; }

///<summary>
///核示日期時間
///[datetime, nullable(True)]
///</summary>
public DateTime? ReviewDate { get; set; }

///<summary>
///資料新增人員
///[char(36), nullable(True)]
///</summary>
public Guid? addUser_Id { get; set; }

///<summary>
///新增日期
///[datetime, nullable(True)]
///</summary>
public DateTime? AddDate { get; set; }

///<summary>
///修改人員
///[char(36), nullable(True)]
///</summary>
public Guid? modUser_Id { get; set; }

///<summary>
///修改日期
///[datetime, nullable(True)]
///</summary>
public DateTime? ModDate { get; set; }
}
}
