using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///費用分攤分攤表明細
/// </summary>
public class ShareCalc_ShareSetting : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ShareCalc_Id { get; set; }

///<summary>
///分攤表ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ShareSetting_Id { get; set; }

///<summary>
///契約容量
///[double, nullable(True)]
///</summary>
public Double? ContractCapacity { get; set; }

///<summary>
///超約附加費
///[double, nullable(True)]
///</summary>
public Double? OverContractFee { get; set; }

///<summary>
///發票號碼
///[varchar(50), nullable(True)]
///</summary>
public string InvoiceNo { get; set; }

///<summary>
///發票金額
///[int(11), nullable(True)]
///</summary>
public Int32? InvoiceAmount { get; set; }
}
}
