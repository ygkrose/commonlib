using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///費用分攤項目明細
/// </summary>
public class ShareCalc_ShareSetting_ChargeItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ShareCalc_ShareSetting_Id { get; set; }

///<summary>
///分攤項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }

///<summary>
///總金額
///[int(11), nullable(False)]
///</summary>
[Required]
public Int32? Amount { get; set; }
}
}
