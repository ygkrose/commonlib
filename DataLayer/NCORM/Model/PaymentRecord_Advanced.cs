using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///收款銷帳預收明細
/// </summary>
public class PaymentRecord_Advanced : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid PaymentRecord_Id { get; set; }

///<summary>
///In/Out(收進/取用)
///[varchar(3), nullable(True)]
///</summary>
public string Direction { get; set; }

///<summary>
///預繳單ID
///[char(36), nullable(True)]
///</summary>
public Guid? PaymentSlip_Advanced_Id { get; set; }

///<summary>
///金額
///[double, nullable(True)]
///</summary>
public Double? Amount { get; set; }

///<summary>
///預收備註
///[varchar(50), nullable(True)]
///</summary>
public string AdvanceMemo { get; set; }

///<summary>
///收費項目
///[char(36), nullable(True)]
///</summary>
public Guid? ChargeItem_Id { get; set; }

///<summary>
///預收、保證金、暫收
///[varchar(20), nullable(True)]
///</summary>
public string AdvanceTerm { get; set; }

///<summary>
///傳票別
///[varchar(20), nullable(True)]
///</summary>
public string VoucherTerm { get; set; }
}
}
