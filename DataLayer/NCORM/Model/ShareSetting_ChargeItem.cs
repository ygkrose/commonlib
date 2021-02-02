using System;
using NewCity.DataAccess.Model;
using System.ComponentModel.DataAnnotations;

namespace NewCity.DataAccess.Model
{
/// <summary>
///分攤表項目明細
/// </summary>
public class ShareSetting_ChargeItem : TableBase
{



///<summary>
///頭檔ID
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ShareSetting_Id { get; set; }

///<summary>
///分攤項目
///[char(36), nullable(False)]
///</summary>
[Required]
public Guid ChargeItem_Id { get; set; }
}
}
